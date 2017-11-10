using Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPSchoolUI
{
    public partial class PrincipalWindow : Form
    {
        public PrincipalWindow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            StudentMenu theStudentMenu = new StudentMenu(mainPanel);
            mainPanel.Controls.Add(theStudentMenu);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            SchoolVanMenu theSchoolVanMenu = new SchoolVanMenu(mainPanel);
            mainPanel.Controls.Add(theSchoolVanMenu);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            UserControl theSubjectMenu = new SubjectMenu(mainPanel);
            mainPanel.Controls.Add(theSubjectMenu);
        }

        private void teacherManagement_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            TeacherMenu theTeacherMenu = new TeacherMenu(mainPanel);
            mainPanel.Controls.Add(theTeacherMenu);
        }

        private void buttonTestData_Click(object sender, EventArgs e)
        {
            try
            {
                AddTestData newTestData = new AddTestData();
                newTestData.AddTestDataToSystem();
                MessageBox.Show("Los Datos de Prueba se cargaron en el sistema", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonTestData.Enabled = false;
                mainPanel.Controls.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PrincipalWindow_Load(object sender, EventArgs e)
        {
            this.AutoScaleDimensions = new System.Drawing.SizeF(100F, 110F);
            this.PerformAutoScale();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            ActivityMenu theActivityMenu = new ActivityMenu(mainPanel);
            mainPanel.Controls.Add(theActivityMenu);
        }
    }
}
