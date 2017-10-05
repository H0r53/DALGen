namespace DALGen_Beta
{
    partial class SQLAttributePicker
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ddlDataType = new System.Windows.Forms.ComboBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.chkPrimaryKey = new System.Windows.Forms.CheckBox();
            this.chkForeignKey = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAttributeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReferencingEntity = new System.Windows.Forms.Label();
            this.txtReferencingEntity = new System.Windows.Forms.TextBox();
            this.lblReferencingAttribute = new System.Windows.Forms.Label();
            this.txtReferencingAttribute = new System.Windows.Forms.TextBox();
            this.chkAutoInc = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ddlDataType
            // 
            this.ddlDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataType.FormattingEnabled = true;
            this.ddlDataType.Location = new System.Drawing.Point(115, 27);
            this.ddlDataType.Margin = new System.Windows.Forms.Padding(2);
            this.ddlDataType.MaxDropDownItems = 30;
            this.ddlDataType.Name = "ddlDataType";
            this.ddlDataType.Size = new System.Drawing.Size(102, 21);
            this.ddlDataType.Sorted = true;
            this.ddlDataType.TabIndex = 15;
            this.ddlDataType.SelectedIndexChanged += new System.EventHandler(this.ddlDataType_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(303, 27);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(50, 20);
            this.txtSize.TabIndex = 16;
            // 
            // chkPrimaryKey
            // 
            this.chkPrimaryKey.AutoSize = true;
            this.chkPrimaryKey.Location = new System.Drawing.Point(364, 3);
            this.chkPrimaryKey.Margin = new System.Windows.Forms.Padding(2);
            this.chkPrimaryKey.Name = "chkPrimaryKey";
            this.chkPrimaryKey.Size = new System.Drawing.Size(92, 17);
            this.chkPrimaryKey.TabIndex = 17;
            this.chkPrimaryKey.Text = "Is Primary Key";
            this.chkPrimaryKey.UseVisualStyleBackColor = true;
            this.chkPrimaryKey.CheckedChanged += new System.EventHandler(this.chkPrimaryKey_CheckedChanged);
            // 
            // chkForeignKey
            // 
            this.chkForeignKey.AutoSize = true;
            this.chkForeignKey.Location = new System.Drawing.Point(364, 38);
            this.chkForeignKey.Margin = new System.Windows.Forms.Padding(2);
            this.chkForeignKey.Name = "chkForeignKey";
            this.chkForeignKey.Size = new System.Drawing.Size(93, 17);
            this.chkForeignKey.TabIndex = 19;
            this.chkForeignKey.Text = "Is Foreign Key";
            this.chkForeignKey.UseVisualStyleBackColor = true;
            this.chkForeignKey.CheckedChanged += new System.EventHandler(this.chkForeignKey_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attribute Name";
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.Location = new System.Drawing.Point(115, 3);
            this.txtAttributeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(238, 20);
            this.txtAttributeName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attribute Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Size/Properties";
            // 
            // lblReferencingEntity
            // 
            this.lblReferencingEntity.AutoSize = true;
            this.lblReferencingEntity.Location = new System.Drawing.Point(2, 56);
            this.lblReferencingEntity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencingEntity.Name = "lblReferencingEntity";
            this.lblReferencingEntity.Size = new System.Drawing.Size(94, 13);
            this.lblReferencingEntity.TabIndex = 8;
            this.lblReferencingEntity.Text = "Referencing Entity";
            // 
            // txtReferencingEntity
            // 
            this.txtReferencingEntity.Location = new System.Drawing.Point(115, 54);
            this.txtReferencingEntity.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferencingEntity.Name = "txtReferencingEntity";
            this.txtReferencingEntity.Size = new System.Drawing.Size(102, 20);
            this.txtReferencingEntity.TabIndex = 20;
            // 
            // lblReferencingAttribute
            // 
            this.lblReferencingAttribute.AutoSize = true;
            this.lblReferencingAttribute.Location = new System.Drawing.Point(220, 56);
            this.lblReferencingAttribute.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReferencingAttribute.Name = "lblReferencingAttribute";
            this.lblReferencingAttribute.Size = new System.Drawing.Size(107, 13);
            this.lblReferencingAttribute.TabIndex = 10;
            this.lblReferencingAttribute.Text = "Referencing Attribute";
            // 
            // txtReferencingAttribute
            // 
            this.txtReferencingAttribute.Location = new System.Drawing.Point(331, 54);
            this.txtReferencingAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferencingAttribute.Name = "txtReferencingAttribute";
            this.txtReferencingAttribute.Size = new System.Drawing.Size(125, 20);
            this.txtReferencingAttribute.TabIndex = 21;
            // 
            // chkAutoInc
            // 
            this.chkAutoInc.AutoSize = true;
            this.chkAutoInc.Location = new System.Drawing.Point(364, 21);
            this.chkAutoInc.Margin = new System.Windows.Forms.Padding(2);
            this.chkAutoInc.Name = "chkAutoInc";
            this.chkAutoInc.Size = new System.Drawing.Size(98, 17);
            this.chkAutoInc.TabIndex = 18;
            this.chkAutoInc.Text = "Auto Increment";
            this.chkAutoInc.UseVisualStyleBackColor = true;
            this.chkAutoInc.CheckedChanged += new System.EventHandler(this.chkAutoInc_CheckedChanged);
            // 
            // SQLAttributePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAutoInc);
            this.Controls.Add(this.txtReferencingAttribute);
            this.Controls.Add(this.lblReferencingAttribute);
            this.Controls.Add(this.txtReferencingEntity);
            this.Controls.Add(this.lblReferencingEntity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAttributeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkForeignKey);
            this.Controls.Add(this.chkPrimaryKey);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.ddlDataType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SQLAttributePicker";
            this.Size = new System.Drawing.Size(461, 76);
            this.Load += new System.EventHandler(this.SQLAttributePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlDataType;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.CheckBox chkPrimaryKey;
        private System.Windows.Forms.CheckBox chkForeignKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAttributeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReferencingEntity;
        private System.Windows.Forms.TextBox txtReferencingEntity;
        private System.Windows.Forms.Label lblReferencingAttribute;
        private System.Windows.Forms.TextBox txtReferencingAttribute;
        private System.Windows.Forms.CheckBox chkAutoInc;
    }
}
