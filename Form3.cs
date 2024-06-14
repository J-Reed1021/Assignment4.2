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
    public partial class Form3 : Form
    {
        Student newStudent = new Student();

        public Form3()
        {
            InitializeComponent();
        }

        private void AddStudentbutton_Click(object sender, EventArgs e)
        {
            if (IDtextbox.Text != "")
            {
                newStudent.StudentId = IDtextbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student ID");
            }

            if (IDtextbox.Text != "")
            {
                newStudent.StudentId = IDtextbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student ID");
            }
            if (Nametextbox.Text != "")
            {
                newStudent.StudentName = Nametextbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter Student Name");
            }
            if (GPAtextbox.Text != "")
            {
                newStudent.GPA = Convert.ToDouble(GPAtextbox.Text);
            }
            else
            {
                MessageBox.Show("Please enter Student GPA");
            }

             Program.StudentList.Add(newStudent);
            StreamWriter writer = new Stream
        }    
    }
}
