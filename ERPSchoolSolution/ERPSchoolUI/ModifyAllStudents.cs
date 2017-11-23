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
    public partial class ModifyAllStudents : UserControl
    {
        private List<object> allStudents;
        private Panel mainPanel;
        private int actualElement;

        public ModifyAllStudents(Panel mainPanel, List<object> allStudents)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            this.allStudents = allStudents;
            this.actualElement = 0;
            LoadValues(allStudents.ElementAt(actualElement));
        }
        public void LoadValues(Object anObject)
        {
            StudentModule module = new StudentModule();
            try
            {
                module.LoadFields(anObject, textBoxName, textBoxLastName, textBoxStudentNumber, numericUpDownCI, numericUpDownX, numericUpDownY, listBoxSubjects, new ListBox());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateElements()
        {
            List<Object> subjects = new List<Object>();
            foreach (Object item in listBoxSubjects.Items)
            {
                subjects.Add(item);
            }
            StudentModule module = new StudentModule();
            module.ModifyStudent(allStudents.ElementAt(actualElement), textBoxName.Text, textBoxLastName.Text, (int)numericUpDownCI.Value,
                (int)numericUpDownX.Value, (int)numericUpDownY.Value, subjects);
            actualElement++;
            if (actualElement < allStudents.Count)
            {
                LoadValues(allStudents.ElementAt(actualElement));
            }
            else
            {
                mainPanel.Controls.Clear();
                CalculateRout calculeRoutes = new CalculateRout(mainPanel);
                mainPanel.Controls.Add(calculeRoutes);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            UpdateElements();
        }
    }
}
