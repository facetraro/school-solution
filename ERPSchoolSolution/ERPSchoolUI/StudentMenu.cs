using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPSchoolUI
{
    public partial class StudentMenu : UserControl
    {
        private Panel mainPanel;
        public StudentMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddStudent addNewStudent = new AddStudent(mainPanel);
            mainPanel.Controls.Add(addNewStudent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RemoveStudent removeAStudent = new RemoveStudent(mainPanel);
            mainPanel.Controls.Add(removeAStudent);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifyStudentSelectList modifyStudent = new ModifyStudentSelectList(mainPanel);
            mainPanel.Controls.Add(modifyStudent);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ConsultStudents consultAStudent = new ConsultStudents(mainPanel);
            mainPanel.Controls.Add(consultAStudent);
        }
    }
}
