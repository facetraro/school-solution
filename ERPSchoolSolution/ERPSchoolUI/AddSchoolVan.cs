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
    public partial class AddSchoolVan : UserControl
    {
        private Panel mainPanel;

        public AddSchoolVan(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SchoolVanMenu backSchoolVanMenu = new SchoolVanMenu(mainPanel);
            mainPanel.Controls.Add(backSchoolVanMenu);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SchoolVanModule module = new SchoolVanModule();
            try
            {
                module.AddNewSchoolVan((int)numericMaxCapacity.Value, (int)numericFuel.Value);
                MessageBox.Show("Camioneta ingresada con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
