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
            // Add support for other DBMS 
        }

        public InputValidationResult ValidateInput()
        {
            if (String.IsNullOrWhiteSpace(txtAttributeName.Text))
                return InputValidationResult.INVALID_ATTRIBUTE_NAME;
            if (String.IsNullOrWhiteSpace(txtReferencingEntity.Text) && chkForeignKey.Checked)
                return InputValidationResult.INVALID_ATTRIBUTE_REF_ENTITY;
            if (String.IsNullOrWhiteSpace(txtReferencingAttribute.Text) && chkForeignKey.Checked)
                return InputValidationResult.INVALID_ATTRIBUTE_REF_ATTRIBUTE;

            // This needs to be improved to support different size types, for example DECIMAL(8,2)
            int tempInt = 0;
            if (txtSize.Enabled && !String.IsNullOrWhiteSpace(txtSize.Text) && !Int32.TryParse(txtSize.Text,out tempInt))
                return InputValidationResult.INVALID_ATTRIBUTE_SIZE;

            // Now that we've passed validation, set the properties of this SQLAttributePicker
            AttributeName = txtAttributeName.Text;
            AttributeSize = !txtSize.Enabled ? null : (int?)tempInt;
            DataType = (DataType)((Item)ddlDataType.SelectedItem).Value;
            ReferenceEntity = txtReferencingEntity.Text;
            ReferenceAttribute = txtReferencingAttribute.Text;
            IsPrimaryKey = chkPrimaryKey.Checked;
            IsForeignKey = chkForeignKey.Checked;

            return InputValidationResult.VALID;
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
            if (this.chkPrimaryKey.Checked)
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
                    chkPrimaryKey.Checked = false;
                    MessageBox.Show(this, "Identity attribute must be of data type int, bigint, smallint, tinyint, or decimal or numeric with a scale of 0, unencrypted, and constrained to be nonnullable.", "Input Validation Error", MessageBoxButtons.OKCancel);
                }
            }
        }
    }
}
