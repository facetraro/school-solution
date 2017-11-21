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
    public partial class RemoveActivity : UserControl
    {
        private Panel mainPanel;
        public RemoveActivity(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            Load();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ActivityMenu backMenu = new ActivityMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }
        private void Load()
        {
            ActivityModule module = new ActivityModule();
            module.LoadAllActivities(listActivities);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listActivitiesSelected.Items.Count != 0)
            {
                foreach (Object item in listActivitiesSelected.Items)
                {
                    ActivityModule module = new ActivityModule();
                    module.RemoveActivity(item);
                }
                MessageBox.Show("Actividad(es) Eliminada(s) con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                ActivityMenu backMenu = new ActivityMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna Actividad para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void selectActivity_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listActivities))
            {
                Object selected = (Object)listActivities.SelectedItem;
                listActivities.Items.Remove(selected);
                listActivitiesSelected.Items.Add(selected);
            }
        }

        private void unselectActivity_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listActivitiesSelected))
            {
                Object selected = (Object)listActivitiesSelected.SelectedItem;
                listActivitiesSelected.Items.Remove(selected);
                listActivities.Items.Add(selected);
            }
        }
    }
}
