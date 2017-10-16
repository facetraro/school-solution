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
    public partial class ConsultStudents : UserControl
    {
        private Panel mainPanel;

        public ConsultStudents(Panel mainPanel)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StudentMenu backStudentMenu = new StudentMenu(mainPanel);
            mainPanel.Controls.Add(backStudentMenu);
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
        private void LoadSubjects(Object selectedItem)
        {
            StudentModule module = new StudentModule();
            try
            {
                module.LoadSubjectsByStudents(selectedItem, listSubjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLookSubjects_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listStudents))
            {
                listSubjects.Items.Clear();
                LoadSubjects(listStudents.SelectedItem);
            }
        }
    }
}
