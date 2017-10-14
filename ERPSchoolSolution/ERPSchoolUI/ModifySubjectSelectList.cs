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
    public partial class ModifySubjectSelectList : UserControl
    {
        private Panel mainPanel;
        public ModifySubjectSelectList(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ModifySubject modifySubject = new ModifySubject(mainPanel);
            mainPanel.Controls.Add(modifySubject);
        }
    }
}
