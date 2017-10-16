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
    public partial class AddSubject : UserControl
    {
        private Panel mainPanel;

        public AddSubject(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            SubjectModule module = new SubjectModule();
            try
            {
                module.AddNewSubject(name);
                MessageBox.Show("Materia ingresada con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
