using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    public enum DataType
    {
        BIT,
        INT,
        CHAR,
        VARCHAR,
        NCHAR,
        NVARCHAR,
        DATE,
        DATETIME,
        DATETIME2
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
}
