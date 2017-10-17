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
    public partial class RemoveTeacher : UserControl
    {
        private Panel mainPanel;
        public RemoveTeacher(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadTeacher();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl teacherMenu = new TeacherMenu(mainPanel);
                mainPanel.Controls.Add(teacherMenu);
            }
        }
        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun Profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadTeacher()
        {
            TeacherModule module = new TeacherModule();
            module.LoadAllTeacher(listTeachers);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TeacherMenu backTeacherMenu = new TeacherMenu(mainPanel);
            mainPanel.Controls.Add(backTeacherMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listTeachersSelected.Items.Count != 0)
            {
                foreach (Object item in listTeachersSelected.Items)
                {
                    TeacherModule module = new TeacherModule();
                    module.RemoveTeacher(item);
                }
                MessageBox.Show("Profesore(s) Eliminado(s) con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                TeacherMenu backMenu = new TeacherMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun Profesor para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void selectTeacher_Click(object sender, EventArgs e)
        {

            if (IsListSelected(listTeachers))
            {
                Object selected = (Object)listTeachers.SelectedItem;
                listTeachers.Items.Remove(selected);
                listTeachersSelected.Items.Add(selected);
            }
        }
        private void unselectTeacher_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listTeachersSelected))
            {
                Object selected = (Object)listTeachersSelected.SelectedItem;
                listTeachersSelected.Items.Remove(selected);
                listTeachers.Items.Add(selected);
            }
        }
    }
}
