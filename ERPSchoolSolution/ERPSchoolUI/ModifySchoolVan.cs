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
    public partial class ModifySchoolVan : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;

        public ModifySchoolVan(Panel mainPanel, Object anObject)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            this.selectedObject = anObject;
            try
            {
                Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Load()
        {
            SchoolVanModule module = new SchoolVanModule();
            module.LoadFields(selectedObject, textIdSchoolVan, numericMaxCapacity, numericFuel);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SchoolVanModule module = new SchoolVanModule();
            try
            {
                module.ModifySchoolVan(selectedObject, textIdSchoolVan, numericMaxCapacity, numericFuel);
                MessageBox.Show("Camioneta modificada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                SchoolVanMenu backMenu = new SchoolVanMenu(mainPanel);
                mainPanel.Controls.Add(backMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
