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
    public partial class ConsultSchoolVans : UserControl
    {
        private Panel mainPanel;
        public ConsultSchoolVans(Panel mainPanel)
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
                UserControl baCkMenu = new SchoolVanMenu(mainPanel);
                mainPanel.Controls.Add(baCkMenu);
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
    }
}
