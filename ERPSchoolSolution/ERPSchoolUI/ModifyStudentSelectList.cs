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
    public partial class ModifyStudentSelectList : UserControl
    {
        private Panel mainPanel;
        public ModifyStudentSelectList(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifyStudent modifyAStudent = new ModifyStudent(mainPanel);
            mainPanel.Controls.Add(modifyAStudent);
        }
    }
}
