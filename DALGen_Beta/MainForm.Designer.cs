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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.chkPHP = new System.Windows.Forms.CheckBox();
            this.radOracle = new System.Windows.Forms.RadioButton();
            this.radMySQL = new System.Windows.Forms.RadioButton();
            this.radTSQL = new System.Windows.Forms.RadioButton();
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
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutDALGenToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutDALGenToolStripMenuItem
            // 
            this.aboutDALGenToolStripMenuItem.Name = "aboutDALGenToolStripMenuItem";
            this.aboutDALGenToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutDALGenToolStripMenuItem.Text = "About DALGen";
            this.aboutDALGenToolStripMenuItem.Click += new System.EventHandler(this.aboutDALGenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPHP);
            this.groupBox1.Controls.Add(this.radOracle);
            this.groupBox1.Controls.Add(this.radMySQL);
            this.groupBox1.Controls.Add(this.radTSQL);
            this.groupBox1.Controls.Add(this.chkJava);
            this.groupBox1.Controls.Add(this.chkPython);
            this.groupBox1.Controls.Add(this.chkCSharp);
            this.groupBox1.Controls.Add(this.chkCPP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(478, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desired Output Files";
            // 
            // chkPHP
            // 
            this.chkPHP.AutoSize = true;
            this.chkPHP.Location = new System.Drawing.Point(395, 103);
            this.chkPHP.Margin = new System.Windows.Forms.Padding(2);
            this.chkPHP.Name = "chkPHP";
            this.chkPHP.Size = new System.Drawing.Size(48, 17);
            this.chkPHP.TabIndex = 7;
            this.chkPHP.Text = "PHP";
            this.chkPHP.UseVisualStyleBackColor = true;
            // 
            // radOracle
            // 
            this.radOracle.AutoSize = true;
            this.radOracle.Enabled = false;
            this.radOracle.Location = new System.Drawing.Point(22, 102);
            this.radOracle.Margin = new System.Windows.Forms.Padding(2);
            this.radOracle.Name = "radOracle";
            this.radOracle.Size = new System.Drawing.Size(56, 17);
            this.radOracle.TabIndex = 2;
            this.radOracle.TabStop = true;
            this.radOracle.Text = "Oracle";
            this.radOracle.UseVisualStyleBackColor = true;
            // 
            // radMySQL
            // 
            this.radMySQL.AutoSize = true;
            this.radMySQL.Location = new System.Drawing.Point(22, 80);
            this.radMySQL.Margin = new System.Windows.Forms.Padding(2);
            this.radMySQL.Name = "radMySQL";
            this.radMySQL.Size = new System.Drawing.Size(60, 17);
            this.radMySQL.TabIndex = 1;
            this.radMySQL.TabStop = true;
            this.radMySQL.Text = "MySQL";
            this.radMySQL.UseVisualStyleBackColor = true;
            this.radMySQL.CheckedChanged += new System.EventHandler(this.radMySQL_CheckedChanged);
            // 
            // radTSQL
            // 
            this.radTSQL.AutoSize = true;
            this.radTSQL.Location = new System.Drawing.Point(22, 58);
            this.radTSQL.Margin = new System.Windows.Forms.Padding(2);
            this.radTSQL.Name = "radTSQL";
            this.radTSQL.Size = new System.Drawing.Size(120, 17);
            this.radTSQL.TabIndex = 0;
            this.radTSQL.TabStop = true;
            this.radTSQL.Text = "SQL Server (T-SQL)";
            this.radTSQL.UseVisualStyleBackColor = true;
            this.radTSQL.CheckedChanged += new System.EventHandler(this.radTSQL_CheckedChanged);
            // 
            // chkJava
            // 
            this.chkJava.AutoSize = true;
            this.chkJava.Enabled = false;
            this.chkJava.Location = new System.Drawing.Point(395, 58);
            this.chkJava.Margin = new System.Windows.Forms.Padding(2);
            this.chkJava.Name = "chkJava";
            this.chkJava.Size = new System.Drawing.Size(49, 17);
            this.chkJava.TabIndex = 5;
            this.chkJava.Text = "Java";
            this.chkJava.UseVisualStyleBackColor = true;
            // 
            // chkPython
            // 
            this.chkPython.AutoSize = true;
            this.chkPython.Enabled = false;
            this.chkPython.Location = new System.Drawing.Point(395, 80);
            this.chkPython.Margin = new System.Windows.Forms.Padding(2);
            this.chkPython.Name = "chkPython";
            this.chkPython.Size = new System.Drawing.Size(59, 17);
            this.chkPython.TabIndex = 6;
            this.chkPython.Text = "Python";
            this.chkPython.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Enabled = false;
            this.chkCSharp.Location = new System.Drawing.Point(297, 81);
            this.chkCSharp.Margin = new System.Windows.Forms.Padding(2);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(40, 17);
            this.chkCSharp.TabIndex = 4;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // chkCPP
            // 
            this.chkCPP.AutoSize = true;
            this.chkCPP.Enabled = false;
            this.chkCPP.Location = new System.Drawing.Point(297, 58);
            this.chkCPP.Margin = new System.Windows.Forms.Padding(2);
            this.chkCPP.Name = "chkCPP";
            this.chkCPP.Size = new System.Drawing.Size(45, 17);
            this.chkCPP.TabIndex = 3;
            this.chkCPP.Text = "C++";
            this.chkCPP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Access Layer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "DBMS Stored Procedures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "DALGen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "The future of automated code generation";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(134, 292);
            this.txtEntityName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(363, 20);
            this.txtEntityName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Entity / Relation Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Schema Name";
            // 
            // txtSchemaName
            // 
            this.txtSchemaName.Location = new System.Drawing.Point(134, 266);
            this.txtSchemaName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSchemaName.Name = "txtSchemaName";
            this.txtSchemaName.Size = new System.Drawing.Size(363, 20);
            this.txtSchemaName.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Namespace";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(134, 319);
            this.txtNamespace.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(363, 20);
            this.txtNamespace.TabIndex = 11;
            // 
            // pnlAttributes
            // 
            this.pnlAttributes.AutoScroll = true;
            this.pnlAttributes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlAttributes.Location = new System.Drawing.Point(19, 369);
            this.pnlAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAttributes.Name = "pnlAttributes";
            this.pnlAttributes.Size = new System.Drawing.Size(478, 292);
            this.pnlAttributes.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(403, 678);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(87, 30);
            this.btnGenerate.TabIndex = 14;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnAddAttribute
            // 
            this.btnAddAttribute.Location = new System.Drawing.Point(298, 678);
            this.btnAddAttribute.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAttribute.Name = "btnAddAttribute";
            this.btnAddAttribute.Size = new System.Drawing.Size(87, 30);
            this.btnAddAttribute.TabIndex = 13;
            this.btnAddAttribute.Text = "Add Attribute";
            this.btnAddAttribute.UseVisualStyleBackColor = true;
            this.btnAddAttribute.Click += new System.EventHandler(this.btnAddAttribute_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 353);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attributes";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(134, 238);
            this.txtDatabaseName.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(363, 20);
            this.txtDatabaseName.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 240);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Database Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 730);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.label9);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkPHP;
    }
}

