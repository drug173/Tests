using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data;


namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для VisitWindow.xaml
    /// </summary>
    public partial class VisitWindow : Window
    {
         ClinicContext db;
        public VisitWindow()
        {

            InitializeComponent();
            db = new ClinicContext();
            db.Patients.Load(); // загружаем данные
            db.Visits.Load();
            //int count_row = MainWindow.GetTableCount("Visits");
            visitGrid.ItemsSource = db.Visits.Local.ToBindingList();

           
        }

        private void patientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        // Добавление записи о посещении
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult dr = new DialogResult();
            VisitAdd visit2 = new VisitAdd();
            dr = visit2.ShowDialog();
            
            if (visit2.cancelFlag == true)
                return;
            else
            {
                Visit visit = new Visit();
                visit2.comboBox2.DisplayMember = "FIELD_TO_DISPLAY";
               // visit2.comboBox2.ValueMember = "FIELD_TO_HIDE";
               // string str=visit2.comboBox2.Text.ToString();
                
                
                int Id_Patient;
                Id_Patient =int.Parse(visit2.comboBox2.SelectedValue.ToString());

               //visit.Patient.Name = str;
                visit.PatientId = Id_Patient;
                visit.Date1 = DateTime.Today;
                visit.TypeOfVisit = visit2.comboBox1.SelectedItem.ToString();
                visit.Diagnosis = visit2.comboBox3.Text;
                

                db.Visits.Add(visit);
                db.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Запись о посещении добавлена!");
            }

        }

        // Удаление посещения
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (visitGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < visitGrid.SelectedItems.Count; i++)
                {
                    Visit visit1 = visitGrid.SelectedItems[i] as Visit;
                    if (visit1 != null)
                    {
                       db.Visits.Remove(visit1);
                    } System.Windows.Forms.MessageBox.Show("Запись посещения удалена!");
                }
            }
            db.SaveChanges();
            
        }

        //сохранение изменений посещений
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           db.SaveChanges();
        }
    }
}
