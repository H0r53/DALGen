using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALGen_Beta
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            // Prevent resizing of the form
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Initialize form components
            InitializeComponent();
        }

        public void AboutForm_Load(object sender, EventArgs e)
        {
            // Add readonly text to form
            txtAbout.Text = "DALGen, the Data Access Layer Generator, prepares a robust database access architecture by automatically generating database objects and code libraries tailored to secure data access. It can produce code for various DBMS platforms, including Microsoft SQL Server, MySQL, and Oracle. Additionally, DALGen can produce secure, object-oriented, data access layers for C++, C#, Java, Python, and PHP. To use the tool, you first design a database E/R diagram. Then, the schema for each entity in the E/R diagram is created via the DALGen graphical user interface. The result is a collection of SQL scripts to create an initial database schema along with stored procedures to perform basic SCRUD (search create read update delete) operations on each entity, as well as object-oriented code libraries for interacting with the generated schema in the programming languages of the user’s preference. Since the timeline of this project is limited, only SQL Server, MySQL, and PHP will be supported initially. During a later release support will be added for other languages.";
            txtAbout.Text += Environment.NewLine + Environment.NewLine;
            txtAbout.Text += "DALGen is an open-source project developed by OpenDevTools. For more information regarding how to use DALGen, how to request support, how to submit bugs, or how to contribute to the DALGen project, please visit ";
            txtAbout.Text += Environment.NewLine;

            // Add hyperlink to https://www.opendevtools.org
            LinkLabel linkLabel = new LinkLabel()
            {
                Text = "https://www.opendevtools.org",
                Location = txtAbout.GetPositionFromCharIndex(this.txtAbout.TextLength),
                BackColor = Color.White,
                Height = 100,
                Width = 1000
            };
            linkLabel.LinkClicked += LinkLabel_Click;
            txtAbout.Controls.Add(linkLabel);

            // Make textbox readonly
            txtAbout.ReadOnly = true;
        }

        // On link click, redirect to URL
        public void LinkLabel_Click(object sender,EventArgs e)
        {
            Process.Start("https://www.opendevtools.org");
        }
    }
}
