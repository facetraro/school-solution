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
            this.buttonTestData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjectManagement
            // 
            resources.ApplyResources(this.subjectManagement, "subjectManagement");
            this.subjectManagement.Name = "subjectManagement";
            this.subjectManagement.UseVisualStyleBackColor = true;
            this.subjectManagement.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // studentManagement
            // 
            resources.ApplyResources(this.studentManagement, "studentManagement");
            this.studentManagement.Name = "studentManagement";
            this.studentManagement.UseVisualStyleBackColor = true;
            this.studentManagement.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherManagement
            // 
            resources.ApplyResources(this.teacherManagement, "teacherManagement");
            this.teacherManagement.Name = "teacherManagement";
            this.teacherManagement.UseVisualStyleBackColor = true;
            this.teacherManagement.Click += new System.EventHandler(this.teacherManagement_Click);
            // 
            // schoolVansManagement
            // 
            resources.ApplyResources(this.schoolVansManagement, "schoolVansManagement");
            this.schoolVansManagement.Name = "schoolVansManagement";
            this.schoolVansManagement.UseVisualStyleBackColor = true;
            this.schoolVansManagement.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // buttonTestData
            // 
            this.buttonTestData.BackColor = System.Drawing.Color.CadetBlue;
            resources.ApplyResources(this.buttonTestData, "buttonTestData");
            this.buttonTestData.Name = "buttonTestData";
            this.buttonTestData.UseVisualStyleBackColor = false;
            this.buttonTestData.Click += new System.EventHandler(this.buttonTestData_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrincipalWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTestData);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.schoolVansManagement);
            this.Controls.Add(this.teacherManagement);
            this.Controls.Add(this.studentManagement);
            this.Controls.Add(this.subjectManagement);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PrincipalWindow";
            this.Load += new System.EventHandler(this.PrincipalWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button subjectManagement;
        private System.Windows.Forms.Button studentManagement;
        private System.Windows.Forms.Button teacherManagement;
        private System.Windows.Forms.Button schoolVansManagement;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonTestData;
        private System.Windows.Forms.Button button1;
    }
}