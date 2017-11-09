/*
Author: Jacob Mills
Description: This abstract class defines operations that are generally reusable for any DAL entity, regardless of the programming language of the DAL being generated.
*/ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    abstract class DALTemplate
    {
        /// <summary>
        /// This method should be overridden in derived classes to define the syntax of generated content
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="outputFilePath"></param>
        public abstract void GenerateContent(DALEntity entity, String outputFilePath);

        /// <summary>
        /// This method capitalizes the first character of a provided string and returns the result
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string UpperFirst(String input)
        {
            if (input.Length == 0) return input;
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        /// <summary>
        /// This method lower-cases the first character of a provided string and returns the result
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string LowerFirst(String input)
        {
            if (input.Length == 0) return input;
            return char.ToLower(input[0]) + input.Substring(1);
        }

        /// <summary>
        /// This method returns a boolean indicating if the provided DataType is associated with a Date or Time
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method returns a string representing the default value of the given DataType
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="defaultStringVal"></param>
        /// <returns></returns>
        public String GetDataTypeDefaultValue(DataType dt, String defaultStringVal = "''")
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
                    returnVal = defaultStringVal;
                    break;
            }
            return returnVal;
        }

        /// <summary>
        /// This method returns the string version of a given DataType. Additionally, if a DataType size is provided the string is appropriately formated for a DBMS.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="dtsize"></param>
        /// <returns></returns>
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
