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
    public partial class CalculateRout : UserControl
    {
        private Panel mainPanel;
        public CalculateRout(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                Load();
                this.mainPanel = mainPanel;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl backMenu = new SchoolVanMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
        }
        private void Load()
        {
            SchoolVanModule module = new SchoolVanModule();
            module.LoadAllSchoolVans(listSchoolVans);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SchoolVanMenu backSchoolVanMenu = new SchoolVanMenu(mainPanel);
            mainPanel.Controls.Add(backSchoolVanMenu);
        }
        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonLookRoutes_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSchoolVans))
            {
                SchoolVanModule module = new SchoolVanModule();
                try
                {
                    routesBox.Clear();
                    module.LoadRoutesBySchoolVan(listSchoolVans.SelectedItem, routesBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
