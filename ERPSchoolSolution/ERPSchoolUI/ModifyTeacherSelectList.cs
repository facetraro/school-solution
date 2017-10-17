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
    public partial class ModifyTeacherSelectList : UserControl
    {
        private Panel mainPanel;
        private void LoeadTeachers()
        {
            TeacherModule module = new TeacherModule();
            module.LoadAllTeacher(listTeachers);
        }
        public ModifyTeacherSelectList(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoeadTeachers();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl backMenu = new TeacherMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
        }
        private bool IsListSelected()
        {
            int selectedIndex = listTeachers.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                mainPanel.Controls.Clear();
                ModifyTeacher modifyATeacher = new ModifyTeacher(mainPanel, listTeachers.SelectedItem);
                mainPanel.Controls.Add(modifyATeacher);
            }
        }
    }
}
