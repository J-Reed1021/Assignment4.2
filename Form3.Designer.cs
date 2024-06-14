namespace Assignment4._2
{
    partial class Form3
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
            IDlabel = new Label();
            Namelabel = new Label();
            GPAlabel = new Label();
            IDtextbox = new TextBox();
            Nametextbox = new TextBox();
            GPAtextbox = new TextBox();
            AddStudentbutton = new Button();
            SuspendLayout();
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(127, 35);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(59, 15);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "StudentID";
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(103, 98);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(83, 15);
            Namelabel.TabIndex = 1;
            Namelabel.Text = "Student Name";
            // 
            // GPAlabel
            // 
            GPAlabel.AutoSize = true;
            GPAlabel.Location = new Point(157, 155);
            GPAlabel.Name = "GPAlabel";
            GPAlabel.Size = new Size(29, 15);
            GPAlabel.TabIndex = 2;
            GPAlabel.Text = "GPA";
            // 
            // IDtextbox
            // 
            IDtextbox.Location = new Point(209, 35);
            IDtextbox.Name = "IDtextbox";
            IDtextbox.Size = new Size(189, 23);
            IDtextbox.TabIndex = 3;
            // 
            // Nametextbox
            // 
            Nametextbox.Location = new Point(209, 90);
            Nametextbox.Name = "Nametextbox";
            Nametextbox.Size = new Size(189, 23);
            Nametextbox.TabIndex = 4;
            // 
            // GPAtextbox
            // 
            GPAtextbox.Location = new Point(209, 147);
            GPAtextbox.Name = "GPAtextbox";
            GPAtextbox.Size = new Size(189, 23);
            GPAtextbox.TabIndex = 5;
            // 
            // AddStudentbutton
            // 
            AddStudentbutton.Location = new Point(259, 210);
            AddStudentbutton.Name = "AddStudentbutton";
            AddStudentbutton.Size = new Size(99, 36);
            AddStudentbutton.TabIndex = 6;
            AddStudentbutton.Text = "Add Student";
            AddStudentbutton.UseVisualStyleBackColor = true;
            AddStudentbutton.Click += AddStudentbutton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddStudentbutton);
            Controls.Add(GPAtextbox);
            Controls.Add(Nametextbox);
            Controls.Add(IDtextbox);
            Controls.Add(GPAlabel);
            Controls.Add(Namelabel);
            Controls.Add(IDlabel);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDlabel;
        private Label Namelabel;
        private Label GPAlabel;
        private TextBox IDtextbox;
        private TextBox Nametextbox;
        private TextBox GPAtextbox;
        private Button AddStudentbutton;
    }
}