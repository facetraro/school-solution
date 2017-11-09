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
    public partial class RemoveActivity : UserControl
    {
        private Panel mainPanel;
        public RemoveActivity(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ActivityMenu backMenu = new ActivityMenu(mainPanel);
            mainPanel.Controls.Add(backMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listActivitiesSelected.Items.Count != 0)
            {
                foreach (Object item in listActivitiesSelected.Items)
                {
                    ActivityModule module = new ActivityModule();
                    //module.RemoveTeacher(item);
                }
                MessageBox.Show("Actividad(es) Eliminada(s) con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                ActivityMenu backMenu = new ActivityMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna Actividad para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
