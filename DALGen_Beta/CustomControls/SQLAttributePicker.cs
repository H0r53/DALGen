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

        public SQLAttributePicker()
        {
            InitializeComponent();
        }

        public InputValidationResult ValidateInput()
        {
            if (String.IsNullOrWhiteSpace(txtAttributeName.Text))
                return InputValidationResult.INVALID_ATTRIBUTE_NAME;
            if (String.IsNullOrWhiteSpace(txtReferencingEntity.Text) && chkForeignKey.Checked)
                return InputValidationResult.INVALID_ATTRIBUTE_REF_ENTITY;
            if (String.IsNullOrWhiteSpace(txtReferencingAttribute.Text) && chkForeignKey.Checked)
                return InputValidationResult.INVALID_ATTRIBUTE_REF_ATTRIBUTE;
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

            ddlDataType.Items.Add(new Item("bit",(int)DataType.BIT));
            ddlDataType.Items.Add(new Item("int", (int)DataType.INT));
            ddlDataType.Items.Add(new Item("char", (int)DataType.CHAR));
            ddlDataType.Items.Add(new Item("varchar", (int)DataType.VARCHAR));
            ddlDataType.Items.Add(new Item("nvar", (int)DataType.NCHAR));
            ddlDataType.Items.Add(new Item("nvarchar", (int)DataType.NVARCHAR));
            ddlDataType.Items.Add(new Item("date", (int)DataType.DATE));
            ddlDataType.Items.Add(new Item("datetime", (int)DataType.DATETIME));
            ddlDataType.Items.Add(new Item("datetime2", (int)DataType.DATETIME2));
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
    }
}
