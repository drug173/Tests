using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class VisitAdd : Form
    {
        public bool cancelFlag = true;
        public VisitAdd()
        {
            InitializeComponent();
            label5.Text = DateTime.Now.ToShortDateString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            cancelFlag = false;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            cancelFlag = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VisitAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet1.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.clinicDataSet1.Patients);
         

        }

    }
}
