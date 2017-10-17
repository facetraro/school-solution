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
    public partial class ModifyTeacher : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;
        public ModifyTeacher(Panel mainPanel, Object anObject)
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
            TeacherModule module = new TeacherModule();
            try
            {
                module.LoadFields(anObject, textNameTeacher, textCode, textLastNameTeacher, listSubjectsSelected, listSubjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TeacherMenu backTeacherMenu = new TeacherMenu(mainPanel);
            mainPanel.Controls.Add(backTeacherMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TeacherModule module = new TeacherModule();
            List<Object> subjects = new List<Object>();
            foreach (Object item in listSubjectsSelected.Items)
            {
                subjects.Add(item);
            }
            try
            {
                module.ModifyTeacher(selectedObject, textNameTeacher.Text, textLastNameTeacher.Text, subjects);
                MessageBox.Show("Profesor modificado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                TeacherMenu backMenu = new TeacherMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectSubject_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjects))
            {
                Object selected = (Object)listSubjects.SelectedItem;
                listSubjects.Items.Remove(selected);
                listSubjectsSelected.Items.Add(selected);
            }
        }

        private void unselectSubject_Click(object sender, EventArgs e)
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
