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
    public partial class ModifyActivity : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;
        public ModifyActivity(Panel mainPanel, Object selectedObject)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            this.selectedObject = selectedObject;
            LoadValues(selectedObject);
        }

        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Actividad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void LoadValues(Object anObject)
        {
            ActivityModule module = new ActivityModule();
            try
            {
                module.LoadFields(anObject, textIDActivity, textNameActivity, textCostActivity, dateTimePicker1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            ActivityModule module = new ActivityModule();
            try
            {
                module.ModifyActivity(selectedObject, textNameActivity.Text, int.Parse(textCostActivity.Text), dateTimePicker1.Value);
                MessageBox.Show("Actividad modificada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                ActivityMenu backActivityMenu = new ActivityMenu(mainPanel);
                mainPanel.Controls.Add(backActivityMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
