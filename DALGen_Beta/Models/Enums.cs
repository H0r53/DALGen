using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    public enum DataType
    {
        // TSQL specific
        BIGINT,
        DECIMAL,
        MONEY,
        NUMERIC,
        SMALLINT,
        SMALLMONEY,
        TINYINT,
        FLOAT,
        REAL,
        BIT,
        INT,
        CHAR,
        VARCHAR,
        NCHAR,
        NVARCHAR,
        DATE,
        DATETIME,
        DATETIME2,
        DATETIMEOFFSET,
        SMALLDATETIME,
        TEXT,
        NTEXT,
        BINARY,
        VARBINARY,
        IMAGE,


        // MySQL Specific
        //CHAR,
        //VARCHAR,
        TINYTEXT,
        //TEXT,
        BLOB,
        MEDIUMTEXT,
        MEDIUMBLOB,
        LONGTEXT,
        LONGBLOB,
        ENUM,
        SET,
        //TINYINT,
        //SMALLINT,
        MEDIUMINT,
        //INT,
        //BIGINT,
        //FLOAT,
        DOUBLE,
        //DECIMAL,
        //DATE,
        //DATETIME,
        TIMESTAMP,
        TIME,
        YEAR

        // Oracle Specific
    }

    public enum InputValidationResult
    {
        VALID,
        NO_OUTPUT,
        INVALID_SCHEMA_NAME,
        INVALID_ENTITY_NAME,
        INVALID_NAMESPACE,
        INVALID_ATTRIBUTE_NAME,
        INVALID_ATTRIBUTE_SIZE,
        INVALID_ATTRIBUTE_REF_ENTITY,
        INVALID_ATTRIBUTE_REF_ATTRIBUTE
    }

    public enum DBMSType
    {
        TSQL,
        MYSQL,
        ORACLE,
        UNKNOWN
    }
}
