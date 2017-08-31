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
            this.SuspendLayout();
            // 
            // ddlDataType
            // 
            this.ddlDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDataType.FormattingEnabled = true;
            this.ddlDataType.Location = new System.Drawing.Point(153, 33);
            this.ddlDataType.MaxDropDownItems = 30;
            this.ddlDataType.Name = "ddlDataType";
            this.ddlDataType.Size = new System.Drawing.Size(134, 24);
            this.ddlDataType.Sorted = true;
            this.ddlDataType.TabIndex = 1;
            this.ddlDataType.SelectedIndexChanged += new System.EventHandler(this.ddlDataType_SelectedIndexChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(394, 33);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(75, 22);
            this.txtSize.TabIndex = 2;
            // 
            // chkPrimaryKey
            // 
            this.chkPrimaryKey.AutoSize = true;
            this.chkPrimaryKey.Location = new System.Drawing.Point(486, 6);
            this.chkPrimaryKey.Name = "chkPrimaryKey";
            this.chkPrimaryKey.Size = new System.Drawing.Size(120, 21);
            this.chkPrimaryKey.TabIndex = 3;
            this.chkPrimaryKey.Text = "Is Primary Key";
            this.chkPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // chkForeignKey
            // 
            this.chkForeignKey.AutoSize = true;
            this.chkForeignKey.Location = new System.Drawing.Point(486, 32);
            this.chkForeignKey.Name = "chkForeignKey";
            this.chkForeignKey.Size = new System.Drawing.Size(120, 21);
            this.chkForeignKey.TabIndex = 4;
            this.chkForeignKey.Text = "Is Foreign Key";
            this.chkForeignKey.UseVisualStyleBackColor = true;
            this.chkForeignKey.CheckedChanged += new System.EventHandler(this.chkForeignKey_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Attribute Name";
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.Location = new System.Drawing.Point(153, 4);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(316, 22);
            this.txtAttributeName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Attribute Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Attribute Size";
            // 
            // lblReferencingEntity
            // 
            this.lblReferencingEntity.AutoSize = true;
            this.lblReferencingEntity.Location = new System.Drawing.Point(3, 69);
            this.lblReferencingEntity.Name = "lblReferencingEntity";
            this.lblReferencingEntity.Size = new System.Drawing.Size(124, 17);
            this.lblReferencingEntity.TabIndex = 8;
            this.lblReferencingEntity.Text = "Referencing Entity";
            // 
            // txtReferencingEntity
            // 
            this.txtReferencingEntity.Location = new System.Drawing.Point(153, 66);
            this.txtReferencingEntity.Name = "txtReferencingEntity";
            this.txtReferencingEntity.Size = new System.Drawing.Size(134, 22);
            this.txtReferencingEntity.TabIndex = 5;
            // 
            // lblReferencingAttribute
            // 
            this.lblReferencingAttribute.AutoSize = true;
            this.lblReferencingAttribute.Location = new System.Drawing.Point(293, 69);
            this.lblReferencingAttribute.Name = "lblReferencingAttribute";
            this.lblReferencingAttribute.Size = new System.Drawing.Size(142, 17);
            this.lblReferencingAttribute.TabIndex = 10;
            this.lblReferencingAttribute.Text = "Referencing Attribute";
            // 
            // txtReferencingAttribute
            // 
            this.txtReferencingAttribute.Location = new System.Drawing.Point(441, 66);
            this.txtReferencingAttribute.Name = "txtReferencingAttribute";
            this.txtReferencingAttribute.Size = new System.Drawing.Size(165, 22);
            this.txtReferencingAttribute.TabIndex = 6;
            // 
            // SQLAttributePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "SQLAttributePicker";
            this.Size = new System.Drawing.Size(615, 94);
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
    }
}
