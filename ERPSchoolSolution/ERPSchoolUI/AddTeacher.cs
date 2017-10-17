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
    public partial class AddTeacher : UserControl
    {
        private Panel mainPanel;
        private void LoadForm()
        {
            SubjectModule module = new SubjectModule();
            module.LoadAllSubjects(listSubjects);
        }
        public AddTeacher(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl theTeacherMenu = new TeacherMenu(mainPanel);
                mainPanel.Controls.Add(theTeacherMenu);
            }
            this.mainPanel = mainPanel;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            module.AddNewTeacher(textNameTeacher.Text, textLastNameTeacher.Text, subjects);
            MessageBox.Show("Profesor ingresado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainPanel.Controls.Clear();
            TeacherMenu backMenu = new TeacherMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjects))
            {
                Object selected = (Object)listSubjects.SelectedItem;
                listSubjects.Items.Remove(selected);
                listSubjectsSelected.Items.Add(selected);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
