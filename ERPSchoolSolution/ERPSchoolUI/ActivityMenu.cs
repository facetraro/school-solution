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
    public partial class ActivityMenu : UserControl
    {
        private Panel mainPanel;
        public ActivityMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            LoadLabels();
        }
        public void LoadLabels()
        {
            ActivityModule module = new ActivityModule();
            labelTitle.Text = module.Name;
            labelDescription.Text = module.Description;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddActivity addNewActivity = new AddActivity(mainPanel);
            mainPanel.Controls.Add(addNewActivity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifyActivitySelectList addNewActivity = new ModifyActivitySelectList(mainPanel);
            mainPanel.Controls.Add(addNewActivity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            RemoveActivity addNewActivity = new RemoveActivity(mainPanel);
            mainPanel.Controls.Add(addNewActivity);
        }

        private void ActivityMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
