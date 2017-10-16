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
    public partial class ModifyStudentSelectList : UserControl
    {
        private Panel mainPanel;

        public ModifyStudentSelectList(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadStudents();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl theStudentMenu = new StudentMenu(mainPanel);
                mainPanel.Controls.Add(theStudentMenu);
            }
        }
        private void LoadStudents()
        {
            StudentModule module = new StudentModule();
            module.LoadAllStudents(listStudents);
        }
        private bool IsListSelected()
        {
            int selectedIndex = listStudents.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                mainPanel.Controls.Clear();
                ModifyStudent modifyAStudent = new ModifyStudent(mainPanel,listStudents.SelectedItem);
                mainPanel.Controls.Add(modifyAStudent);
            }
        }
    }
}
