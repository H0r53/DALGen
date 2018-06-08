using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALGen_Beta
{
    public partial class SQLAttributePicker : UserControl
    {
        private String _attributeName;
        private DataType _dataType;
        private String _attributeSize;
        private bool _isPrimaryKey;
        private bool _autoIncrement;
        private bool _isForeignKey;
        private String _referenceEntity;
        private String _referenceAttribute;

        public string AttributeName { get => _attributeName; set => _attributeName = value; }
        public DataType DataType { get => _dataType; set => _dataType = value; }
        public String AttributeSize { get => _attributeSize; set => _attributeSize = value; }
        public bool IsPrimaryKey { get => _isPrimaryKey; set => _isPrimaryKey = value; }
        public bool AutoIncrement { get => _autoIncrement; set => _autoIncrement = value; }
        public bool IsForeignKey { get => _isForeignKey; set => _isForeignKey = value; }
        public string ReferenceEntity { get => _referenceEntity; set => _referenceEntity = value; }
        public string ReferenceAttribute { get => _referenceAttribute; set => _referenceAttribute = value; }

        // Content item for the combo box
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public SQLAttributePicker(DBMSType dBMSType)
        {
            InitializeComponent();

            if (dBMSType == DBMSType.TSQL)
                LoadTSQLDropDown();
            else if (dBMSType == DBMSType.MYSQL)
                LoadMySQLDropDown();
            // Add support for other DBMS 
        }

        public InputValidationResult ValidateInput()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtAttributeName.Text))
                    return InputValidationResult.INVALID_ATTRIBUTE_NAME;
                if (String.IsNullOrWhiteSpace(txtReferencingEntity.Text) && chkForeignKey.Checked)
                    return InputValidationResult.INVALID_ATTRIBUTE_REF_ENTITY;
                if (String.IsNullOrWhiteSpace(txtReferencingAttribute.Text) && chkForeignKey.Checked)
                    return InputValidationResult.INVALID_ATTRIBUTE_REF_ATTRIBUTE;

                // Since valid inputs range from numbers, comma seperated values, and keywords, no validation is implemented here.
                //int tempInt = 0;
                //if (txtSize.Enabled && String.IsNullOrWhiteSpace(txtSize.Text))
                //    return InputValidationResult.INVALID_ATTRIBUTE_SIZE;

                // Now that we've passed validation, set the properties of this SQLAttributePicker
                AttributeName = txtAttributeName.Text;
                AttributeSize = !txtSize.Enabled ? String.Empty : txtSize.Text;
                DataType = (DataType)((Item)ddlDataType.SelectedItem).Value;
                ReferenceEntity = txtReferencingEntity.Text;
                ReferenceAttribute = txtReferencingAttribute.Text;
                AutoIncrement = chkAutoInc.Checked;
                IsPrimaryKey = chkPrimaryKey.Checked;
                IsForeignKey = chkForeignKey.Checked;

                return InputValidationResult.VALID;
            }
            catch (Exception e)
            {
                return InputValidationResult.GENERIC_ERROR;
            }
            
        }

        private void SQLAttributePicker_Load(object sender, EventArgs e)
        {
            InitializeControl();
            ToggleReferenceVisibility();
        }

        private void InitializeControl()
        {
            txtSize.Text = String.Empty;
            txtSize.Enabled = false;
            chkAutoInc.Enabled = false;
        }

        private void LoadTSQLDropDown()
        {
            ddlDataType.Items.Add(new Item("BIGINT", (int)DataType.BIGINT));
            ddlDataType.Items.Add(new Item("DECIMAL", (int)DataType.DECIMAL));
            ddlDataType.Items.Add(new Item("MONEY", (int)DataType.MONEY));
            ddlDataType.Items.Add(new Item("NUMERIC", (int)DataType.NUMERIC));
            ddlDataType.Items.Add(new Item("SMALLINT", (int)DataType.SMALLINT));
            ddlDataType.Items.Add(new Item("SMALLMONEY", (int)DataType.SMALLMONEY));
            ddlDataType.Items.Add(new Item("TINYINT", (int)DataType.TINYINT));
            ddlDataType.Items.Add(new Item("FLOAT", (int)DataType.FLOAT));
            ddlDataType.Items.Add(new Item("REAL", (int)DataType.REAL));
            ddlDataType.Items.Add(new Item("BIT", (int)DataType.BIT));
            ddlDataType.Items.Add(new Item("INT", (int)DataType.INT));
            ddlDataType.Items.Add(new Item("CHAR", (int)DataType.CHAR));
            ddlDataType.Items.Add(new Item("VARCHAR", (int)DataType.VARCHAR));
            ddlDataType.Items.Add(new Item("NCHAR", (int)DataType.NCHAR));
            ddlDataType.Items.Add(new Item("NVARCHAR", (int)DataType.NVARCHAR));
            ddlDataType.Items.Add(new Item("DATE", (int)DataType.DATE));
            ddlDataType.Items.Add(new Item("DATETIME", (int)DataType.DATETIME));
            ddlDataType.Items.Add(new Item("DATETIME2", (int)DataType.DATETIME2));
            ddlDataType.Items.Add(new Item("DATETIMEOFFSET", (int)DataType.DATETIMEOFFSET));
            ddlDataType.Items.Add(new Item("SMALLDATETIME", (int)DataType.SMALLDATETIME));
            ddlDataType.Items.Add(new Item("TEXT", (int)DataType.TEXT));
            ddlDataType.Items.Add(new Item("NTEXT", (int)DataType.NTEXT));
            ddlDataType.Items.Add(new Item("BINARY", (int)DataType.BINARY));
            ddlDataType.Items.Add(new Item("VARBINARY", (int)DataType.VARBINARY));
            ddlDataType.Items.Add(new Item("IMAGE", (int)DataType.IMAGE));
        }

        private void LoadMySQLDropDown()
        {
            ddlDataType.Items.Add(new Item("CHAR", (int)DataType.CHAR));
            ddlDataType.Items.Add(new Item("VARCHAR", (int)DataType.VARCHAR));
            ddlDataType.Items.Add(new Item("TINYTEXT", (int)DataType.TINYTEXT));
            ddlDataType.Items.Add(new Item("TEXT", (int)DataType.TEXT));
            ddlDataType.Items.Add(new Item("BLOB", (int)DataType.BLOB));
            ddlDataType.Items.Add(new Item("MEDIUMTEXT", (int)DataType.MEDIUMTEXT));
            ddlDataType.Items.Add(new Item("MEDIUMBLOB", (int)DataType.MEDIUMBLOB));
            ddlDataType.Items.Add(new Item("LONGTEXT", (int)DataType.LONGTEXT));
            ddlDataType.Items.Add(new Item("LONGBLOB", (int)DataType.LONGBLOB));
            ddlDataType.Items.Add(new Item("ENUM", (int)DataType.ENUM));
            ddlDataType.Items.Add(new Item("SET", (int)DataType.SET));
            ddlDataType.Items.Add(new Item("TINYINT", (int)DataType.TINYINT));
            ddlDataType.Items.Add(new Item("SMALLINT", (int)DataType.SMALLINT));
            ddlDataType.Items.Add(new Item("MEDIUMINT", (int)DataType.MEDIUMINT));
            ddlDataType.Items.Add(new Item("INT", (int)DataType.INT));
            ddlDataType.Items.Add(new Item("BIGINT", (int)DataType.BIGINT));
            ddlDataType.Items.Add(new Item("FLOAT", (int)DataType.FLOAT));
            ddlDataType.Items.Add(new Item("DOUBLE", (int)DataType.DOUBLE));
            ddlDataType.Items.Add(new Item("DECIMAL", (int)DataType.DECIMAL));
            ddlDataType.Items.Add(new Item("DATE", (int)DataType.DATE));
            ddlDataType.Items.Add(new Item("DATETIME", (int)DataType.DATETIME));
            ddlDataType.Items.Add(new Item("TIMESTAMP", (int)DataType.TIMESTAMP));
            ddlDataType.Items.Add(new Item("TIME", (int)DataType.TIME));
            ddlDataType.Items.Add(new Item("YEAR", (int)DataType.YEAR));
        }

        private void chkForeignKey_CheckedChanged(object sender, EventArgs e)
        {
            ToggleReferenceVisibility();
        }

        private void ToggleReferenceVisibility()
        {
            bool visible = chkForeignKey.Checked;
            lblReferencingEntity.Visible = lblReferencingAttribute.Visible
                = txtReferencingEntity.Visible = txtReferencingAttribute.Visible = visible;
        }

        private void ddlDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)ddlDataType.SelectedItem;
            switch (selectedItem.Value)
            {
                case (int)DataType.CHAR:
                case (int)DataType.VARCHAR:
                case (int)DataType.NCHAR:
                case (int)DataType.NVARCHAR:
                case (int)DataType.BINARY:
                case (int)DataType.VARBINARY:
                case (int)DataType.DECIMAL:
                case (int)DataType.NUMERIC:
                case (int)DataType.FLOAT:
                    txtSize.Enabled = true;
                    break;
                default:
                    txtSize.Text = String.Empty;
                    txtSize.Enabled = false;
                    break;
            }
        }

        private void chkPrimaryKey_CheckedChanged(object sender, EventArgs e)
        {
            chkAutoInc.Enabled = this.chkPrimaryKey.Checked;

            if (!this.chkPrimaryKey.Checked)
            {
                chkAutoInc.Checked = false;
                chkAutoInc.Enabled = false;
            }
        }

        private void chkAutoInc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoInc.Checked)
            {
                bool validIdentity = false;
                Item selectedItem = (Item)ddlDataType.SelectedItem;
                if (selectedItem == null)
                    return;

                switch (selectedItem.Value)
                {
                    case (int)DataType.INT:
                    case (int)DataType.BIGINT:
                    case (int)DataType.SMALLINT:
                    case (int)DataType.TINYINT:
                    case (int)DataType.DECIMAL:
                    case (int)DataType.NUMERIC:
                        validIdentity = true;
                        break;
                }
                if (!validIdentity)
                {
                    chkAutoInc.Checked = false;
                    MessageBox.Show(this, "Identity attribute must be of data type int, bigint, smallint, tinyint, or decimal or numeric with a scale of 0, unencrypted, and constrained to be nonnullable.", "Input Validation Error", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
