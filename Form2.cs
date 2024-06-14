using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._2
{
    public partial class Form2 : Form
    {
        bool logonStatus = false;
        string userName = "Teacher";
        string password = "Admin";

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserNametextBox.Text == userName && PasswordtextBox.Text == password)

            { 
              //if logon successful
              logonStatus = true;
              this.Close();
            }
            else
            {
                ShowDialog("Incorrect username or password");
            }
        }
    }
}
