﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SubjectMenu backSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(backSubjectMenu);
        }
    }
}
