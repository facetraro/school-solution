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
    public partial class TeacherMenu : UserControl
    {
        private Panel mainPanel;
        public TeacherMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddTeacher addNewTeacher = new AddTeacher(mainPanel);
            mainPanel.Controls.Add(addNewTeacher);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RemoveTeacher removeATeacher = new RemoveTeacher(mainPanel);
            mainPanel.Controls.Add(removeATeacher);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifyTeacherSelectList modifyTeacher = new ModifyTeacherSelectList(mainPanel);
            mainPanel.Controls.Add(modifyTeacher);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ConsultTeachers consultATeacher = new ConsultTeachers(mainPanel);
            mainPanel.Controls.Add(consultATeacher);
        }
    }
}
