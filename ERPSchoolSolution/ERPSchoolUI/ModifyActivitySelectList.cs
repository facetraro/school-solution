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
    public partial class ModifyActivitySelectList : UserControl
    {
        private Panel mainPanel;
        public ModifyActivitySelectList(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadActivity();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl backMenu = new ActivityMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);

            }
        }
        private bool IsListSelected()
        {
            int selectedIndex = listActivities.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void LoadActivity()
        {
            ActivityModule module = new ActivityModule();
            module.LoadAllActivities(listActivities);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                Object selectedObject = (Object)listActivities.SelectedItem;
                mainPanel.Controls.Clear();
                ModifyActivity modifyActivity = new ModifyActivity(mainPanel, selectedObject);
                mainPanel.Controls.Add(modifyActivity);
            }
        }

        private void ModifyActivitySelectList_Load(object sender, EventArgs e)
        {

        }
    }
}
