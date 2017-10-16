using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPSchoolUI
{

    public partial class RemoveSchoolVan : UserControl
    {
        private Panel mainPanel;

        public RemoveSchoolVan(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SchoolVanMenu backSchoolVanMenu = new SchoolVanMenu(mainPanel);
            mainPanel.Controls.Add(backSchoolVanMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
