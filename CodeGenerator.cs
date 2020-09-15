using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EkCodeGenerator;

namespace IceInk
{
    public partial class CodeGenerator : Form
    {
        public CodeGenerator()
        {
            InitializeComponent();
        }

        private static string strConn = string.Empty;
        private static string selectTableConn = string.Empty;

        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            strConn = string.Empty;
            if (string.IsNullOrWhiteSpace(databaseUrlbox.Text))
            {
                MessageBox.Show("请输入数据库主机名称/IP地址！！！");
                return;
            }
            if (string.IsNullOrWhiteSpace(databaseUrlbox.Text))
            {
                MessageBox.Show("请输入数据库登录用户名！！！");
                return;
            }
            if (string.IsNullOrWhiteSpace(databaseUrlbox.Text))
            {
                MessageBox.Show("请输入数据库登录密码！！！");
                return;
            }
            try
            {
                List<string> databaseNamelist = new List<string>();
                strConn = $"server={databaseUrlbox.Text.Trim()};uid={databaseIdbox.Text.Trim()};pwd={databasePassbox.Text.Trim()};";
                using (SqlConnection connection = new SqlConnection(strConn))
                {
                    connection.Open();
                    MessageBox.Show("连接成功！！！");
                    this.databaseCheckList.Items.Clear();
                    this.tableCheckList.Items.Clear();
                    string selectDataBaseListSql = "SELECT NAME FROM MASTER.DBO.SYSDATABASES ORDER BY NAME";
                    SqlCommand sqlCommand = new SqlCommand(selectDataBaseListSql, connection);
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        this.databaseCheckList.Items.Add(dataReader["NAME"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "连接失败");
                return;
            }
        }

        /// <summary>
        /// 选择某一个数据库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseCheckList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox control = (CheckedListBox)sender;
            #region 设置单选
            if (control.CheckedItems.Count > 0)
            {
                for (int i = 0; i < control.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        control.SetItemChecked(i, false);
                    }
                }
            }
            #endregion
            selectTableConn = strConn + $"database={control.SelectedItem};";
            using (SqlConnection connection = new SqlConnection(selectTableConn))
            {
                connection.Open();
                string selectDataBaseListSql = "SELECT NAME FROM SYSOBJECTS WHERE XTYPE='U' ORDER BY NAME";
                SqlCommand sqlCommand = new SqlCommand(selectDataBaseListSql, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                this.tableCheckList.Items.Clear();
                while (dataReader.Read())
                {
                    this.tableCheckList.Items.Add(dataReader["NAME"].ToString());
                }
            }
        }

        /// <summary>
        /// 委托封装
        /// </summary>
        /// <param name="action"></param>
        /// <param name="strSql"></param>
        private void ExecSql(Action<SqlDataReader> action, string strSql)
        {
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(strSql, connection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                action.Invoke(dataReader);
            }
        }

        /// <summary>
        /// 生成代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateAndSaveFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txSpaceName.Text))
            {
                MessageBox.Show("请输入命名空间！！");
                return;
            }
            Dictionary<string, Dictionary<string, string>> tabledicList = new Dictionary<string, Dictionary<string, string>>();
            string selectDatabaseName = this.databaseCheckList.SelectedItem.ToString();
            foreach (string tabelName in this.tableCheckList.CheckedItems)
            {
                string selectTableConn = strConn + $"database={selectDatabaseName};";
                string selectFileds = $"select COLUMN_NAME,DATA_TYPE from information_schema.COLUMNS where TABLE_Name = '{tabelName}'";
                Dictionary<string, string> propTypediclist = new Dictionary<string, string>();
                using (SqlConnection connection = new SqlConnection(selectTableConn))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(selectFileds, connection);
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        propTypediclist.Add(dataReader["COLUMN_NAME"].ToString(), dataReader["DATA_TYPE"].ToString());
                    }
                }
                tabledicList.Add(tabelName, propTypediclist);
            }
            //开始生成
            //--命名空间
            string spaceName = txSpaceName.Text.Trim();
            CreateFileHelper.CreateCsFile(spaceName, tabledicList);

            //清空输入
            //ClearInput();
        }

        /// <summary>
        /// 开始创建CS文件
        /// </summary>
        /// <param name="tabledicList"></param>
        private void CreateFile(Dictionary<string, Dictionary<string, string>> tabledicList)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            var selectPath = path.SelectedPath;
            foreach (var item in tabledicList)
            {
                string filePath = $"{selectPath}\\{item.Key}.cs";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"using System;\r\n");
                sb.AppendLine($"namespace  {txSpaceName.Text.Trim()}");
                sb.AppendLine("{");
                sb.AppendLine($"    public class {item.Key}");
                sb.AppendLine("    {");
                foreach (var prop in item.Value)
                {
                    string propName = prop.Key;
                    string propType = prop.Value;


                    #region 类型识别转换
                    //string propTypeLower = propType.ToLower();
                    //if (propTypeLower.Contains("char"))
                    //{
                    //    propType = "string";
                    //}
                    //else if (propTypeLower.Contains("datetime"))
                    //{
                    //    propType = "DateTime";
                    //}
                    //else if (propTypeLower.Contains("bit"))
                    //{
                    //    propType = "bool";
                    //}
                    //else if (propTypeLower.Contains("uniqueidentifier"))
                    //{
                    //    propType = "Guid";
                    //}
                    //else if (propTypeLower.Contains("int"))
                    //{
                    //    propType = "int";
                    //}

                    #endregion

                    propType = SqlTypeToSqlDbTypeHelper.SqlServerType2CSharpType(propType);

                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine("        /// ");
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine($"        public {propType} {propName} {{ get; set; }}");
                    sb.AppendLine();
                }
                sb.AppendLine("    }");
                sb.AppendLine("}");
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
            }
            MessageBox.Show($"代码已经生成在【{selectPath}】 下");
        }

        /// <summary>
        /// 清空输入
        /// </summary>
        private void ClearInput()
        {
            this.databaseUrlbox.Text = null;
            this.databaseIdbox.Text = null;
            this.databasePassbox.Text = null;
            this.databaseCheckList.Items.Clear();
            this.tableCheckList.Items.Clear();
            this.txSpaceName.Text = null;
            strConn = null;
            selectTableConn = null;

        }
        private void CodeGenerator_Load(object sender, EventArgs e)
        {
            this.databaseUrlbox.Text = "127.0.0.1";
            this.databaseIdbox.Text = "sa";
            this.databasePassbox.Text = "123456";
        }

    }
}

