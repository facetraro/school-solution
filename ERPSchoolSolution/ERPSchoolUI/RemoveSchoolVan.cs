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

    public partial class RemoveSchoolVan : UserControl
    {
        private Panel mainPanel;

        public RemoveSchoolVan(Panel mainPanel)
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
        private void Load()
        {
            SchoolVanModule module = new SchoolVanModule();
            module.LoadAllSchoolVans(listSchoolVan);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SchoolVanMenu backMenu = new SchoolVanMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listSchoolVansSelected.Items.Count != 0)
            {
                foreach (Object item in listSchoolVansSelected.Items)
                {
                    SchoolVanModule module = new SchoolVanModule();
                    module.RemoveSchoolVan(item);
                }
                MessageBox.Show("Camioneta(s) Eliminada(s) con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                SchoolVanMenu backMenu = new SchoolVanMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            else
            {
                MessageBox.Show("No se han seleccionado Camionetas para borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void selectSchoolVan_Click(object sender, EventArgs e)
        {

            if (IsListSelected(listSchoolVan))
            {
                Object selected = (Object)listSchoolVan.SelectedItem;
                listSchoolVan.Items.Remove(selected);
                listSchoolVansSelected.Items.Add(selected);
            }
        }

        private void unselectSchoolVan_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSchoolVansSelected))
            {
                Object selected = (Object)listSchoolVansSelected.SelectedItem;
                listSchoolVansSelected.Items.Remove(selected);
                listSchoolVan.Items.Add(selected);
            }
        }
    }
}
