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
    public partial class RemoveSubject : UserControl
    {
        private Panel mainPanel;
        public RemoveSubject(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadSubjects();
                this.mainPanel = mainPanel;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl theSubjectMenu = new SubjectMenu(mainPanel);
                mainPanel.Controls.Add(theSubjectMenu);
            }
        }
        private void LoadSubjects()
        {
            SubjectModule module = new SubjectModule();
            module.LoadAllSubjects(listSubjects);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            if (listSubjectsSelected.Items.Count != 0)
            {
                foreach (Object item in listSubjectsSelected.Items)
                {
                    SubjectModule module = new SubjectModule();
                    module.RemoveSubject(item);
                }
                MessageBox.Show("Materia(s) Eliminada(s) con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPanel.Controls.Clear();
                SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
                mainPanel.Controls.Add(backSubjectMenu);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado para borrar Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsListSelected(ListBox list)
        {
            int selectedIndex = list.SelectedIndex;
            if (selectedIndex == -1)
            {
                MessageBox.Show("No se ha seleccionado ninguna Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void addSubject_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjects))
            {
                Object selected = (Object)listSubjects.SelectedItem;
                listSubjects.Items.Remove(selected);
                listSubjectsSelected.Items.Add(selected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsListSelected(listSubjectsSelected))
            {
                Object selected = (Object)listSubjectsSelected.SelectedItem;
                listSubjectsSelected.Items.Remove(selected);
                listSubjects.Items.Add(selected);
            }
        }
    }
}
