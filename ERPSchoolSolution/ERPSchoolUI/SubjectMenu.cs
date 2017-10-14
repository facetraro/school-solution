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
    public partial class SubjectMenu : UserControl
    {
        private Panel mainPanel;
        public SubjectMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddSubject addNewSubject = new AddSubject(mainPanel);
            mainPanel.Controls.Add(addNewSubject);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifySubjectSelectList modifySubjectSelect = new ModifySubjectSelectList(mainPanel);
            mainPanel.Controls.Add(modifySubjectSelect);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RemoveSubject removeASubject = new RemoveSubject(mainPanel);
            mainPanel.Controls.Add(removeASubject);
        }
    }
}
