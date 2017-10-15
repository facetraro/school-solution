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
    public partial class ModifySchoolVanSelectList : UserControl
    {
        private Panel mainPanel;
        public ModifySchoolVanSelectList(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifySchoolVan modifyASchoolVan = new ModifySchoolVan(mainPanel);
            mainPanel.Controls.Add(modifyASchoolVan);
        }
    }
}
