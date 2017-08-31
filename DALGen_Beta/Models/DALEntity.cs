using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALGen_Beta
{
    public class DALEntity
    {
        private String _entityName;
        private String _schemaName;
        private String _namespaceName;
        private List<DALAttributes> _attributes;

        public DALEntity(string entityName, string schemaName, string namespaceName)
        {
            _entityName = entityName;
            _schemaName = schemaName;
            _namespaceName = namespaceName;
            _attributes = new List<DALAttributes>();
        }

        public string EntityName { get => _entityName; set => _entityName = value; }
        public string SchemaName { get => _schemaName; set => _schemaName = value; }
        public string NamespaceName { get => _namespaceName; set => _namespaceName = value; }
        public List<DALAttributes> Attributes { get => _attributes; set => _attributes = value; }
    }

    public class DALAttributes
    {
        private String _attributeName;
        private DataType _dataType;
        private int? _attributeSize;
        private bool _isPrimaryKey;
        private bool _isForeignKey;
        private String _referenceEntity;
        private String _referenceAttribute;

        public string AttributeName { get => _attributeName; set => _attributeName = value; }
        public DataType DataType { get => _dataType; set => _dataType = value; }
        public int? AttributeSize { get => _attributeSize; set => _attributeSize = value; }
        public bool IsPrimaryKey { get => _isPrimaryKey; set => _isPrimaryKey = value; }
        public bool IsForeignKey { get => _isForeignKey; set => _isForeignKey = value; }
        public string ReferenceEntity { get => _referenceEntity; set => _referenceEntity = value; }
        public string ReferenceAttribute { get => _referenceAttribute; set => _referenceAttribute = value; }

        public DALAttributes(string name, DataType type, int? size, bool isPrimaryKey, bool isForeignKey, string referenceEntity, string referenceAttribute)
        {
            _attributeName = name;
            _dataType = type;
            _attributeSize = size;
            _isPrimaryKey = isPrimaryKey;
            _isForeignKey = isForeignKey;
            _referenceEntity = referenceEntity;
            _referenceAttribute = referenceAttribute;
        }
    }
}
