﻿using System;
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
    public partial class AddStudent : UserControl
    {
        private Panel mainPanel;
        private void LoadForm()
        {
            SubjectModule module = new SubjectModule();
            module.LoadAllSubjects(listSubjects);
        }
        public AddStudent(Panel mainPanel)
        {
            InitializeComponent();
            try
            {
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UserControl theStudentMenu = new StudentMenu(mainPanel);
                mainPanel.Controls.Add(theStudentMenu);
            }
            this.mainPanel = mainPanel;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StudentMenu backStudentMenu = new StudentMenu(mainPanel);
            mainPanel.Controls.Add(backStudentMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            StudentModule module = new StudentModule();
            List<Object> subjects = new List<Object>();
            foreach (Object item in listSubjectsSelected.Items)
            {
                subjects.Add(item);
            }
            module.AddNewStudent(textNameStudent.Text, textLastNameStudent.Text, (int)numericCi.Value, (int)numericX.Value, (int)numericY.Value, subjects);
            MessageBox.Show("Alumno ingresado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void removeSubject_Click(object sender, EventArgs e)
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
