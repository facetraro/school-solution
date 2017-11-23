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
    public partial class ConsultPayments : UserControl
    {
        private Panel panel;
        public ConsultPayments(Panel aPanel)
        {
            this.panel = aPanel;
            InitializeComponent();
            LoadStudents();
        }
        private void LoadStudents()
        {
            StudentModule module = new StudentModule();
            module.LoadAllStudents(listBox1);
        }
        private void LoadPaymentsByStudent(object selected)
        {
            PaymentModule module = new PaymentModule();
            listBox2.Items.Clear();
            module.LoadConsultPaymentsByStudent(selected,listBox2);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = (Object)listBox1.SelectedItem;
            if (selected != null)
            {
                LoadPaymentsByStudent(selected);
            }
        }
    }
}
