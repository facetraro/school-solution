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
    public partial class SchoolVanMenu : UserControl
    {
        private Panel mainPanel;
        public SchoolVanMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddSchoolVan addANewSchoolVan = new AddSchoolVan(mainPanel);
            mainPanel.Controls.Add(addANewSchoolVan);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifySchoolVanSelectList modifyASchoolVan = new ModifySchoolVanSelectList(mainPanel);
            mainPanel.Controls.Add(modifyASchoolVan);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RemoveSchoolVan removeASchoolVan = new RemoveSchoolVan(mainPanel);
            mainPanel.Controls.Add(removeASchoolVan);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ConsultSchoolVans consultASchoolVan = new ConsultSchoolVans(mainPanel);
            mainPanel.Controls.Add(consultASchoolVan);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            CalculateRout calculateARoute = new CalculateRout(mainPanel);
            mainPanel.Controls.Add(calculateARoute);
        }
    }
}
