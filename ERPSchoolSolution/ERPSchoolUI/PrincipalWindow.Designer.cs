namespace ERPSchoolUI
{
    partial class PrincipalWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalWindow));
            this.subjectManagement = new System.Windows.Forms.Button();
            this.studentManagement = new System.Windows.Forms.Button();
            this.teacherManagement = new System.Windows.Forms.Button();
            this.schoolVansManagement = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // subjectManagement
            // 
            this.subjectManagement.Location = new System.Drawing.Point(101, 161);
            this.subjectManagement.Name = "subjectManagement";
            this.subjectManagement.Size = new System.Drawing.Size(157, 60);
            this.subjectManagement.TabIndex = 1;
            this.subjectManagement.Text = "Gestión Materias";
            this.subjectManagement.UseVisualStyleBackColor = true;
            this.subjectManagement.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // studentManagement
            // 
            this.studentManagement.Location = new System.Drawing.Point(101, 298);
            this.studentManagement.Name = "studentManagement";
            this.studentManagement.Size = new System.Drawing.Size(157, 60);
            this.studentManagement.TabIndex = 2;
            this.studentManagement.Text = "Gestión Alumnos";
            this.studentManagement.UseVisualStyleBackColor = true;
            this.studentManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherManagement
            // 
            this.teacherManagement.Location = new System.Drawing.Point(101, 433);
            this.teacherManagement.Name = "teacherManagement";
            this.teacherManagement.Size = new System.Drawing.Size(157, 60);
            this.teacherManagement.TabIndex = 3;
            this.teacherManagement.Text = "Gestión Docentes";
            this.teacherManagement.UseVisualStyleBackColor = true;
            this.teacherManagement.Click += new System.EventHandler(this.teacherManagement_Click);
            // 
            // schoolVansManagement
            // 
            this.schoolVansManagement.Location = new System.Drawing.Point(101, 564);
            this.schoolVansManagement.Name = "schoolVansManagement";
            this.schoolVansManagement.Size = new System.Drawing.Size(157, 60);
            this.schoolVansManagement.TabIndex = 4;
            this.schoolVansManagement.Text = "Gestión Camionetas";
            this.schoolVansManagement.UseVisualStyleBackColor = true;
            this.schoolVansManagement.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.Location = new System.Drawing.Point(381, 117);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(637, 630);
            this.mainPanel.TabIndex = 5;
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 774);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.schoolVansManagement);
            this.Controls.Add(this.teacherManagement);
            this.Controls.Add(this.studentManagement);
            this.Controls.Add(this.subjectManagement);
            this.Name = "PrincipalWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subjectManagement;
        private System.Windows.Forms.Button studentManagement;
        private System.Windows.Forms.Button teacherManagement;
        private System.Windows.Forms.Button schoolVansManagement;
        private System.Windows.Forms.Panel mainPanel;
    }
}