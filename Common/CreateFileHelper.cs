#region << 文 件 说 明 >>
/*----------------------------------------------------------------
// 文件名称：CreateFileHelper
// 创 建 者：IceInk
// 创建时间：2020/9/15 16:37:05
// 文件版本：V1.0.0
// ===============================================================
// 功能描述：
//		
//		
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EkCodeGenerator
{
    /// <summary>
    /// 创建CS文件
    /// </summary>
    public static class CreateFileHelper
    {
        /// <summary>
        /// 创建Cs文件
        /// </summary>
        /// <param name="spaceName">命名空间</param>
        /// <param name="tabledicList">数据库表信息</param>
        public static void CreateCsFile(string spaceName, Dictionary<string, Dictionary<string, string>> tabledicList)
        {
            //选择生成到的目标文件夹
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            string selectPath = path.SelectedPath;
            foreach (var item in tabledicList)
            {
                string filePath = $"{selectPath}\\{item.Key}.cs";
                StringBuilder sb = new StringBuilder();
                //添加默认引用
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Collections.Generic;");
                sb.AppendLine("using System.Text;\r\n");
                //添加命名空间
                sb.AppendLine($"namespace  {spaceName.Trim()}");
                sb.AppendLine("{");
                //类名
                sb.AppendLine($"    public class {item.Key}");
                sb.AppendLine("    {");
                //添加字段
                foreach (var prop in item.Value)
                {
                    string propName = prop.Key;
                    string propType = prop.Value;

                    //类型转换 把sqlserver数据类型转换为C#类型
                    propType = SqlTypeToSqlDbTypeHelper.SqlServerType2CSharpType(propType);

                    sb.AppendLine("        /// <summary>");
                    sb.AppendLine($"        /// {propName}");//默认注释
                    sb.AppendLine("        /// </summary>");
                    sb.AppendLine($"        public {propType} {propName} {{ get; set; }}");//字段
                    sb.AppendLine();
                }
                sb.AppendLine("    }");
                sb.AppendLine("}");
                //写入文件
                File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
                Console.WriteLine($"生成成功：{filePath}");
            }

            string tipsPath = $"代码已经生成在【{selectPath}】 下";
            MessageBox.Show(tipsPath);


        }
    }
}
