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
    public partial class ModifySchoolVanSelectList : UserControl
    {
        private Panel mainPanel;
        public ModifySchoolVanSelectList(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadSchoolVan();
                this.mainPanel = mainPanel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl backMenu = new SchoolVanMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
        }
        private void LoadSchoolVan()
        {
            SchoolVanModule module = new SchoolVanModule();
            module.LoadAllSchoolVans(listSchoolVans);
        }
        private bool IsListSelected()
        {
            int selectedIndex = listSchoolVans.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna camioneta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected())
            {
                Object selectedObject = (Object)listSchoolVans.SelectedItem;
                mainPanel.Controls.Clear();
                ModifySchoolVan modifySubject = new ModifySchoolVan(mainPanel, selectedObject);
                mainPanel.Controls.Add(modifySubject);
            }
        }
    }
}
