using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic
{
    public partial class PatientVisitForm : Form
    {
        string[] month;
        public PatientVisitForm()
        {
            InitializeComponent();

            label2.Text = PatientWindow.namePatient;
             using(ClinicContext db=new ClinicContext())
             {
                 month = new string[13];
                 month[1] = "январь";
                 month[2] = "февраль";
                 month[3] = "март";
                 month[4] = "апрель";
                 month[5] = "май";
                 month[6] = "июнь";
                 month[7] = "июль";
                 month[8] = "август";
                 month[9] = "сентябрь";
                 month[10] = "октябрь";
                 month[11] = "ноябрь";
                 month[12] = "декабрь";

                 string st="28.01.2019 0:00:00";
                 string st1 = "Вторичный приём";
                 DateTime d=DateTime.Parse(st);
                 DataSet ds = new DataSet();

               /* var visitCount = from p in db.Visits
                                   where p.PatientId == PatientWindow.idPatient    //выбираем строки по ID пациента
                                         && p.Date.Month == 1                       
                                         && p.TypeOfVisit == "Вторичный приём"
                                   select COUNT(new VisitPatientCount
                                   {
                                       Month = month[p.Date.Month],
                                       Diagnosis = "Болен",
                                       VisitCount = 1
                                   }); */
                 System.Data.SqlClient.SqlParameter param = new System.Data.SqlClient.SqlParameter("@ID1", PatientWindow.idPatient);
                 System.Data.SqlClient.SqlParameter param1 = new System.Data.SqlClient.SqlParameter("@TYPEVISIT1", "Вторичный приём");
                 System.Data.SqlClient.SqlParameter COUNT1 = new System.Data.SqlClient.SqlParameter
                 {
                     ParameterName = "@COUNT",
                     SqlDbType = SqlDbType.Int,
                     Direction = ParameterDirection.Output // параметр выходной
                 };
                 SqlParameter COUNT2 = new SqlParameter
                 {
                     ParameterName = "@COUNT",
                     SqlDbType = SqlDbType.Int,
                     Direction = ParameterDirection.ReturnValue  // параметр выходной
                 };

                 var visitCount = db.Visits.SqlQuery("SELECT * FROM Visits WHERE(  Visits.PatientId = @ID1  AND Visits.TypeOfVisit =@TYPEVISIT1 )", param, param1);
                // var visitCount = db.Visits.SqlQuery("CountVisit @ID1, @TYPEVISIT1, @COUNT", param, param1, COUNT1);
                 int rows = dataGridView1.Rows.Count;
 
                
                 foreach (var p in visitCount)
                 {

                     dataGridView1.Rows.Add(month[p.Date1.Month], p.Diagnosis, p.VisitCount);
                      //System.Windows.Forms.MessageBox.Show(month[p.Date.Month]);
                
                 }
         
                     
                 }

                }
                    
            
    

        private void PatientVisitForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clinicDataSet1.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.clinicDataSet1.Patients);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
