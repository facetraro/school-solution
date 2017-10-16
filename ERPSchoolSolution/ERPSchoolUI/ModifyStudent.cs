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
    public partial class ModifyStudent : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;
        public ModifyStudent(Panel mainPanel, Object anObject)
        {
            InitializeComponent();
            selectedObject = anObject;
            LoadValues(selectedObject);
            this.mainPanel = mainPanel;
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
        public void LoadValues(Object anObject)
        {
            StudentModule module = new StudentModule();
            try
            {
                module.LoadFields(anObject, textNameStudent, textLastNameStudent, textStudentNumber, numericCi, numericX, numericY, listSubjectsSelected, listSubjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StudentMenu backStudentMenu = new StudentMenu(mainPanel);
            mainPanel.Controls.Add(backStudentMenu);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            StudentModule module = new StudentModule();
            List<Object> subjects = new List<Object>();
            foreach (Object item in listSubjectsSelected.Items)
            {
                subjects.Add(item);
            }
            try
            {
                module.ModifyStudent(selectedObject, textNameStudent.Text, textLastNameStudent.Text, (int)numericCi.Value, (int)numericX.Value, (int)numericY.Value, subjects);
                MessageBox.Show("Alumno modificado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                StudentMenu backStudentMenu = new StudentMenu(mainPanel);
                mainPanel.Controls.Add(backStudentMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addSubject_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjects))
            {
                Object selected = (Object)listSubjects.SelectedItem;
                listSubjects.Items.Remove(selected);
                listSubjectsSelected.Items.Add(selected);
            }
        }

        private void removeSubject_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjectsSelected))
            {
                Object selected = (Object)listSubjectsSelected.SelectedItem;
                listSubjectsSelected.Items.Remove(selected);
                listSubjects.Items.Add(selected);
            }
        }
    }
}
