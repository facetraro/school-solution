using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module;

namespace ERPSchoolUI
{
    public partial class ModifySubjectSelectList : UserControl
    {
        private Panel mainPanel;
        public ModifySubjectSelectList(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            LoadSubjects();
        }
        private void LoadSubjects()
        {
            SubjectModule module = new SubjectModule();
            module.LoadAllSubjects(listSubjects);
        }
        private bool IsListSelected()
        {
            int selectedIndex = listSubjects.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                Object selectedObject = (Object)listSubjects.SelectedItem;
                mainPanel.Controls.Clear();
                ModifySubject modifySubject = new ModifySubject(mainPanel, selectedObject);
                mainPanel.Controls.Add(modifySubject);
            }
        }
    }
}
