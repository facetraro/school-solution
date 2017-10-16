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
    public partial class ModifySubject : UserControl
    {
        private Panel mainPanel;
        private Object selectedObject;
        public ModifySubject(Panel mainPanel, Object selectedObject)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            this.selectedObject = selectedObject;
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
            SubjectModule module = new SubjectModule();
            module.LoadFields(selectedObject, textName, textCode);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SubjectModule module = new SubjectModule();
            try
            {
                module.ModifySubject(selectedObject, textName, textCode);
                MessageBox.Show("Materia modificada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
                mainPanel.Controls.Add(backSubjectMenu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
