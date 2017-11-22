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
    public partial class AddSubscription : UserControl
    {
        private Panel mainPanel;

        public AddSubscription(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            try
            {
                LoadStudents();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                PaymentMenu backMenu = new PaymentMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
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

        private void GoBackMenu()
        {
            mainPanel.Controls.Clear();
            PaymentMenu backMenu = new PaymentMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            GoBackMenu();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                PaymentModule module = new PaymentModule();
                Object selected = (Object)listStudents.SelectedItem;
                try
                {
                    module.AddSubscription(selected, (int)numericMaxYear.Value, (int)numericUpDownMonth.Value);
                    MessageBox.Show("Se ha pagado la subscripcion con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
