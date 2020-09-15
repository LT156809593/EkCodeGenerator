#region << 文 件 说 明 >>
/*----------------------------------------------------------------
// 文件名称：SqlTypeToSqlDbTypeHelper
// 创 建 者：IceInk
// 创建时间：2020/9/14 16:41:59
// 文件版本：V1.0.0
// ===============================================================
// 功能描述：
//		
//		
//----------------------------------------------------------------*/
#endregion

using System;
using System.Data;
using System.Windows.Forms;

namespace EkCodeGenerator
{
    /// <summary>
    /// 
    /// </summary>
    public static class SqlTypeToSqlDbTypeHelper
    {
        /// <summary>
        /// SqlServer数据类型转换为C#类型
        /// </summary>
        /// <param name="sqlTypeString"></param>
        /// <returns></returns>
        public static string SqlServerType2CSharpType(string sqlTypeString)
        {
            string reval = string.Empty;
            switch (sqlTypeString.ToLower())
            {
                //short
                case "smallint":
                    reval = "short";
                    break;
                //byte
                case "tinyint":
                    reval = "byte";
                    break;
                //int
                case "int":
                    reval = "int";
                    break;
                //float 
                case "real":
                    reval = "float";
                    break;
                //double
                case "float":
                    reval = "double";
                    break;
                //long
                case "bigint":
                    reval = "long";
                    break;
                //bool
                case "bit":
                    reval = "bool";
                    break;
                //string
                case "nchar":
                case "ntext":
                case "char":
                case "text":
                case "nvarchar":
                case "varchar":
                    reval = "string";
                    break;
                //byte[]
                case "binary":
                case "image":
                case "varbinary":
                    reval = "byte[]";
                    break;
                //decimal
                case "money":
                case "numeric":
                case "decimal":
                case "smallmoney":
                    reval = "decimal";
                    break;
                //DateTime
                case "datetime":
                case "datetime2":
                case "smalldatetime":
                case "timestamp":
                    reval = "DateTime";
                    break;
                //Guid
                case "uniqueidentifier":
                    reval = "Guid";
                    break;
                //object
                case "variant":
                    reval = "object";
                    break;
                default:
                    string tipsError = $"类型转换错误：{sqlTypeString}";
                    Console.WriteLine(tipsError);
                    MessageBox.Show(tipsError, "错误");
                    break;
            }
            return reval;


        }


        /// <summary>
        /// SqlDbType转换为C#数据类型
        /// </summary>
        /// <param name="sqlType"></param>
        /// <returns></returns>
        public static string SqlDbType2CsharpType(SqlDbType sqlType)
        {
            switch (sqlType)
            {
                case SqlDbType.BigInt:
                    return "long";
                case SqlDbType.Binary:
                    return ("byte[]");
                case SqlDbType.Bit:
                    return ("bool");
                case SqlDbType.Char:
                    return ("string");
                case SqlDbType.DateTime:
                    return ("DateTime");
                case SqlDbType.Decimal:
                    return ("decimal");
                case SqlDbType.Float:
                    return ("double");
                case SqlDbType.Image:
                    return ("byte[]");
                case SqlDbType.Int:
                    return ("int");
                case SqlDbType.Money:
                    return ("decimal");
                case SqlDbType.NChar:
                    return ("string");
                case SqlDbType.NText:
                    return ("string");
                case SqlDbType.NVarChar:
                    return ("string");
                case SqlDbType.Real:
                    return ("float");
                case SqlDbType.SmallDateTime:
                    return ("DateTime");
                case SqlDbType.SmallInt:
                    return ("short");
                case SqlDbType.SmallMoney:
                    return ("decimal");
                case SqlDbType.Text:
                    return ("string");
                case SqlDbType.Timestamp:
                    return ("byte[]");
                case SqlDbType.TinyInt:
                    return ("byte");
                case SqlDbType.Udt://自定义的数据类型
                    return ("object");
                case SqlDbType.UniqueIdentifier:
                    return ("Guid");
                case SqlDbType.VarBinary:
                    return ("byte[]");
                case SqlDbType.VarChar:
                    return ("string");
                case SqlDbType.Variant:
                    return ("object");
                case SqlDbType.Xml:
                    return ("object");
                default:
                    return null;
            }
        }



        /// <summary>
        /// sql server数据类型（如：varchar）转换为SqlDbType类型
        /// </summary>
        /// <param name="sqlTypeString"></param>
        /// <returns></returns>
        public static SqlDbType SqlServerType2SqlDbType(string sqlTypeString)
        {
            SqlDbType dbType = SqlDbType.Variant;//默认为Object

            switch (sqlTypeString.ToLower())
            {
                case "int":
                    dbType = SqlDbType.Int;
                    break;
                case "varchar":
                    dbType = SqlDbType.VarChar;
                    break;
                case "bit":
                    dbType = SqlDbType.Bit;
                    break;
                case "datetime":
                    dbType = SqlDbType.DateTime;
                    break;
                case "decimal":
                    dbType = SqlDbType.Decimal;
                    break;
                case "float":
                    dbType = SqlDbType.Float;
                    break;
                case "image":
                    dbType = SqlDbType.Image;
                    break;
                case "money":
                    dbType = SqlDbType.Money;
                    break;
                case "ntext":
                    dbType = SqlDbType.NText;
                    break;
                case "nvarchar":
                    dbType = SqlDbType.NVarChar;
                    break;
                case "smalldatetime":
                    dbType = SqlDbType.SmallDateTime;
                    break;
                case "smallint":
                    dbType = SqlDbType.SmallInt;
                    break;
                case "text":
                    dbType = SqlDbType.Text;
                    break;
                case "bigint":
                    dbType = SqlDbType.BigInt;
                    break;
                case "binary":
                    dbType = SqlDbType.Binary;
                    break;
                case "char":
                    dbType = SqlDbType.Char;
                    break;
                case "nchar":
                    dbType = SqlDbType.NChar;
                    break;
                case "numeric":
                    dbType = SqlDbType.Decimal;
                    break;
                case "real":
                    dbType = SqlDbType.Real;
                    break;
                case "smallmoney":
                    dbType = SqlDbType.SmallMoney;
                    break;
                case "sql_variant":
                    dbType = SqlDbType.Variant;
                    break;
                case "timestamp":
                    dbType = SqlDbType.Timestamp;
                    break;
                case "tinyint":
                    dbType = SqlDbType.TinyInt;
                    break;
                case "uniqueidentifier":
                    dbType = SqlDbType.UniqueIdentifier;
                    break;
                case "varbinary":
                    dbType = SqlDbType.VarBinary;
                    break;
                case "xml":
                    dbType = SqlDbType.Xml;
                    break;
            }
            return dbType;
        }
    }
}
