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
    public partial class ModifyActivity : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;
        public ModifyActivity(Panel mainPanel, Object selectedObject)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            this.selectedObject = selectedObject;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ActivityMenu backSubjectMenu = new ActivityMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }
    }
}
