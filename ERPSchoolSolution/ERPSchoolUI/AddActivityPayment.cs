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
    public partial class AddActivityPayment : UserControl
    {
        private Panel mainPanel;
        public AddActivityPayment(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            try
            {
                LoadActivities();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PaymentMenu backMenu = new PaymentMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
        }

        private void LoadActivities()
        {
            ActivityModule module = new ActivityModule();
            module.LoadAllActivities(listActivities);
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
        private void backButton_Click(object sender, EventArgs e)
        {
            GoBackMenu();
        }
        private void GoBackMenu()
        {
            mainPanel.Controls.Clear();
            PaymentMenu backMenu = new PaymentMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }
        private void LoadStudentList()
        {
            try
            {
                ActivityModule module = new ActivityModule();
                Object selected = (Object)listActivities.SelectedItem;
                module.LoadStudentsOfSelectedActivity(listStudents, selected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = (Object)listActivities.SelectedItem;
            if (selected != null)
            {
                LoadStudentList();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                PaymentModule module = new PaymentModule();
                Object selStudent = (Object)listStudents.SelectedItem;
                Object selActivity = (Object)listActivities.SelectedItem;
                try
                {
                    module.AddNewActivityPayment(selActivity, selStudent);
                    MessageBox.Show("Se ha pagado la actividad con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GoBackMenu();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
