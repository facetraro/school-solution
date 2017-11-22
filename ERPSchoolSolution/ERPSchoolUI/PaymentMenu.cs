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
    public partial class PaymentMenu : UserControl
    {
        Panel mainPanel;
        public PaymentMenu(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            LoadLabels();
        }
        public void LoadLabels()
        {
            PaymentModule module = new PaymentModule();
            labelTitle.Text = module.Name;
            labelDescription.Text = module.Description;
        }

        private void modifyActivity_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddSubscription addNewActivity = new AddSubscription(mainPanel);
            mainPanel.Controls.Add(addNewActivity);
        }

        private void addActivity_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            AddActivityPayment addNewActivityPayment = new AddActivityPayment(mainPanel);
            mainPanel.Controls.Add(addNewActivityPayment);
        }
    }
}
