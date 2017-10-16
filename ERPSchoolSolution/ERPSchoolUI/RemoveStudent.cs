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
    public partial class RemoveStudent : UserControl
    {
        private Panel mainPanel;

        public RemoveStudent(Panel mainPanel)
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
                UserControl theSubjectMenu = new SubjectMenu(mainPanel);
                mainPanel.Controls.Add(theSubjectMenu);
            }
        }
        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadStudents()
        {
            StudentModule module = new StudentModule();
            module.LoadAllStudents(listStudents);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StudentMenu backStudentMenu = new StudentMenu(mainPanel);
            mainPanel.Controls.Add(backStudentMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listStudentsSelected.Items.Count != 0)
            {
                foreach (Object item in listStudentsSelected.Items)
                {
                    StudentModule module = new StudentModule();
                    module.RemoveStudent(item);
                }
                MessageBox.Show("Alumnos Eliminados con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se han seleccionado Alumnos para borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selectStudent_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listStudents))
            {
                Object selected = (Object)listStudents.SelectedItem;
                listStudents.Items.Remove(selected);
                listStudentsSelected.Items.Add(selected);
            }
        }

        private void unselectStudent_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listStudentsSelected))
            {
                Object selected = (Object)listStudentsSelected.SelectedItem;
                listStudentsSelected.Items.Remove(selected);
                listStudents.Items.Add(selected);
            }
        }
    }
}
