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
    public partial class ConsultTeachers : UserControl
    {
        private Panel mainPanel;

        public ConsultTeachers(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadTeachers();
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
            TeacherMenu backMenu = new TeacherMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }

        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ningun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadTeachers()
        {
            TeacherModule module = new TeacherModule();
            module.LoadAllTeacher(listTeachers);
        }
        private void LoadSubjects(Object selectedItem)
        {
            TeacherModule module = new TeacherModule();
            try
            {
                module.LoadSubjectsByTeacher(selectedItem, listSubjects);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLookSubjects_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listTeachers))
            {
                listSubjects.Items.Clear();
                LoadSubjects(listTeachers.SelectedItem);
            }
        }
    }
}
