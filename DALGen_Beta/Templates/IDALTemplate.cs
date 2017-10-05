using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    abstract class DALTemplate
    {
        public abstract void GenerateContent(DALEntity entity, String outputFilePath);

        public bool IsDateDataType(DataType dt)
        {
            bool returnVal = false;

            switch (dt)
            {
                case DataType.DATE:
                case DataType.DATETIME:
                case DataType.DATETIME2:
                case DataType.DATETIMEOFFSET:
                case DataType.SMALLDATETIME:
                case DataType.TIMESTAMP:
                case DataType.TIME:
                case DataType.YEAR:
                    returnVal = true;
                    break;
                default:
                    break;
            }

            return returnVal;
        }

        public String GetDataTypeDefaultValue(DataType dt)
        {
            String returnVal = String.Empty;
            switch (dt)
            {
                case DataType.INT:
                case DataType.BIGINT:
                case DataType.FLOAT:
                case DataType.DECIMAL:
                case DataType.MONEY:
                case DataType.NUMERIC:
                case DataType.SMALLINT:
                case DataType.MEDIUMINT:
                case DataType.SMALLMONEY:
                case DataType.TINYINT:
                case DataType.REAL:
                    returnVal = "0";
                    break;
                default:
                    returnVal = "''";
                    break;
            }
            return returnVal;
        }

        public String GetDataTypeString(DataType dt, String dtsize)
        {
            String returnVal = "UNKNOWN";
            switch (dt)
            {
                case DataType.BIGINT:
                    returnVal = "BIGINT";
                    break;
                case DataType.DECIMAL:
                    returnVal = "DECIMAL";
                    break;
                case DataType.MONEY:
                    returnVal = "MONEY";
                    break;
                case DataType.NUMERIC:
                    returnVal = "NUMERIC";
                    break;
                case DataType.SMALLINT:
                    returnVal = "SMALLINT";
                    break;
                case DataType.SMALLMONEY:
                    returnVal = "SMALLMONEY";
                    break;
                case DataType.TINYINT:
                    returnVal = "TINYINT";
                    break;
                case DataType.FLOAT:
                    returnVal = "FLOAT";
                    break;
                case DataType.REAL:
                    returnVal = "REAL";
                    break;
                case DataType.BIT:
                    returnVal = "BIT";
                    break;
                case DataType.INT:
                    returnVal = "INT";
                    break;
                case DataType.CHAR:
                    returnVal = "CHAR";
                    break;
                case DataType.VARCHAR:
                    returnVal = "VARCHAR";
                    break;
                case DataType.NCHAR:
                    returnVal = "NCHAR";
                    break;
                case DataType.NVARCHAR:
                    returnVal = "NVARCHAR";
                    break;
                case DataType.DATE:
                    returnVal = "DATE";
                    break;
                case DataType.DATETIME:
                    returnVal = "DATETIME";
                    break;
                case DataType.DATETIME2:
                    returnVal = "DATETIME2";
                    break;
                case DataType.DATETIMEOFFSET:
                    returnVal = "DATETIMEOFFSET";
                    break;
                case DataType.SMALLDATETIME:
                    returnVal = "SMALLDATETIME";
                    break;
                case DataType.TEXT:
                    returnVal = "TEXT";
                    break;
                case DataType.NTEXT:
                    returnVal = "NTEXT";
                    break;
                case DataType.BINARY:
                    returnVal = "BINARY";
                    break;
                case DataType.VARBINARY:
                    returnVal = "VARBINARY";
                    break;
                case DataType.IMAGE:
                    returnVal = "IMAGE";
                    break;

                // MySQL Specific
                case DataType.TINYTEXT:
                    returnVal = "TINYTEXT";
                    break;
                case DataType.BLOB:
                    returnVal = "BLOB";
                    break;
                case DataType.MEDIUMTEXT:
                    returnVal = "MEDIUMTEXT";
                    break;
                case DataType.MEDIUMBLOB:
                    returnVal = "MEDIUMBLOB";
                    break;
                case DataType.LONGTEXT:
                    returnVal = "LONGTEXT";
                    break;
                case DataType.LONGBLOB:
                    returnVal = "LONGBLOB";
                    break;
                case DataType.ENUM:
                    returnVal = "ENUM";
                    break;
                case DataType.SET:
                    returnVal = "SET";
                    break;
                case DataType.MEDIUMINT:
                    returnVal = "MEDIUMINT";
                    break;
                case DataType.DOUBLE:
                    returnVal = "DOUBLE";
                    break;
                case DataType.TIMESTAMP:
                    returnVal = "TIMESTAMP";
                    break;
                case DataType.TIME:
                    returnVal = "TIME";
                    break;
                case DataType.YEAR:
                    returnVal = "YEAR";
                    break;
            }

            if (!String.IsNullOrWhiteSpace(dtsize))
                returnVal += "(" + dtsize + ")";

            return returnVal;
        }
    }
}
