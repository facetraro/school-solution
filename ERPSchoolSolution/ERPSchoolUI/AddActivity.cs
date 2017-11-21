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
    public partial class AddActivity : UserControl
    {
        private Panel mainPanel;
        public AddActivity(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddActivity_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ActivityModule module = new ActivityModule();
            List<Object> activities = new List<Object>();

            try
            {
                module.AddNewActivity(textNameActivity.Text, dateTimePicker1.Value, int.Parse(textCost.Text));
                MessageBox.Show("Actividad ingresada con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                StudentMenu backMenu = new StudentMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ActivityMenu backMenu = new ActivityMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }
    }
    
}
