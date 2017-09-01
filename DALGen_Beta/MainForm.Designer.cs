namespace DALGen_Beta
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDALGenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkJava = new System.Windows.Forms.CheckBox();
            this.chkPython = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.chkCPP = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSchemaName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.pnlAttributes = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnAddAttribute = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.radTSQL = new System.Windows.Forms.RadioButton();
            this.radMySQL = new System.Windows.Forms.RadioButton();
            this.radOracle = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutDALGenToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutDALGenToolStripMenuItem
            // 
            this.aboutDALGenToolStripMenuItem.Name = "aboutDALGenToolStripMenuItem";
            this.aboutDALGenToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.aboutDALGenToolStripMenuItem.Text = "About DALGen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOracle);
            this.groupBox1.Controls.Add(this.radMySQL);
            this.groupBox1.Controls.Add(this.radTSQL);
            this.groupBox1.Controls.Add(this.chkJava);
            this.groupBox1.Controls.Add(this.chkPython);
            this.groupBox1.Controls.Add(this.chkCSharp);
            this.groupBox1.Controls.Add(this.chkCPP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desired Output Files";
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Location = new System.Drawing.Point(527, 72);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(60, 21);
            this.chkJava.TabIndex = 5;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkPython
            // 
            this.chkPython.AutoSize = true;
            this.chkPython.Location = new System.Drawing.Point(527, 99);
            this.chkPython.Name = "chkPython";
            this.chkPython.Size = new System.Drawing.Size(74, 21);
            this.chkPython.TabIndex = 6;
            this.chkPython.Text = "Python";
            this.chkPython.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(396, 99);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(47, 21);
            this.chkCSharp.TabIndex = 4;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkCPP
            // 
            this.chkCPP.AutoSize = true;
            this.chkCPP.Location = new System.Drawing.Point(396, 72);
            this.chkCPP.Name = "chkCPP";
            this.chkCPP.Size = new System.Drawing.Size(55, 21);
            this.chkCPP.TabIndex = 3;
            this.chkCPP.Text = "C++";
            this.chkCPP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Access Layer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "DBMS Stored Procedures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "DALGen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "The future of automated code generation";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(179, 315);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(483, 22);
            this.txtEntityName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Entity / Relation Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Schema Name";
            // 
            // txtSchemaName
            // 
            this.txtSchemaName.Location = new System.Drawing.Point(179, 283);
            this.txtSchemaName.Name = "txtSchemaName";
            this.txtSchemaName.Size = new System.Drawing.Size(483, 22);
            this.txtSchemaName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Namespace";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(179, 348);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(483, 22);
            this.txtNamespace.TabIndex = 9;
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.AutoScroll = true;
            this.pnlAttributes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAttributes.Location = new System.Drawing.Point(25, 410);
            this.pnlAttributes.Name = "pnlAttributes";
            this.pnlAttributes.Size = new System.Drawing.Size(638, 359);
            this.pnlAttributes.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(537, 790);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 37);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Location = new System.Drawing.Point(398, 790);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(116, 37);
            this.btnAddAttribute.TabIndex = 11;
            this.btnAddAttribute.Text = "Add Attribute";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            this.btnAddAttribute.Click += new System.EventHandler(this.btnAddAttribute_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attributes";
            // 
            // radTSQL
            // 
            this.radTSQL.AutoSize = true;
            this.radTSQL.Location = new System.Drawing.Point(30, 72);
            this.radTSQL.Name = "radTSQL";
            this.radTSQL.Size = new System.Drawing.Size(159, 21);
            this.radTSQL.TabIndex = 0;
            this.radTSQL.TabStop = true;
            this.radTSQL.Text = "SQL Server (T-SQL)";
            this.radTSQL.UseVisualStyleBackColor = true;
            this.radTSQL.CheckedChanged += new System.EventHandler(this.radTSQL_CheckedChanged);
            // 
            // radMySQL
            // 
            this.radMySQL.AutoSize = true;
            this.radMySQL.Enabled = false;
            this.radMySQL.Location = new System.Drawing.Point(30, 99);
            this.radMySQL.Name = "radMySQL";
            this.radMySQL.Size = new System.Drawing.Size(75, 21);
            this.radMySQL.TabIndex = 1;
            this.radMySQL.TabStop = true;
            this.radMySQL.Text = "MySQL";
            this.radMySQL.UseVisualStyleBackColor = true;
            // 
            // radOracle
            // 
            this.radOracle.AutoSize = true;
            this.radOracle.Enabled = false;
            this.radOracle.Location = new System.Drawing.Point(30, 126);
            this.radOracle.Name = "radOracle";
            this.radOracle.Size = new System.Drawing.Size(71, 21);
            this.radOracle.TabIndex = 2;
            this.radOracle.TabStop = true;
            this.radOracle.Text = "Oracle";
            this.radOracle.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 850);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddAttribute);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pnlAttributes);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSchemaName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "DALGen - The DAL Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDALGenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkJava;
        private System.Windows.Forms.CheckBox chkPython;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.CheckBox chkCPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSchemaName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Panel pnlAttributes;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnAddAttribute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radOracle;
        private System.Windows.Forms.RadioButton radMySQL;
        private System.Windows.Forms.RadioButton radTSQL;
    }
}

