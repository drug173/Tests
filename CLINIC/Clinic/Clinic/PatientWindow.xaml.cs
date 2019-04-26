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
    /// Логика взаимодействия для PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        ClinicContext db;
     public static int idPatient;
      public  static string namePatient;
        public PatientWindow()
        {
            InitializeComponent();
            db = new ClinicContext();
            db.Patients.Load(); // загружаем данные
            db.Visits.Load();
            patientGrid.ItemsSource = db.Patients.Local.ToBindingList();
            
        }


        private void patientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
            // просмотр посещения пациента
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (patientGrid.SelectedItems.Count > 0)
            {
                Patient patient1 = patientGrid.SelectedItems[0] as Patient;
                namePatient = patient1.Name;
                idPatient = patient1.Id;
                DialogResult dr = new DialogResult();
                PatientVisitForm patient2 = new PatientVisitForm();
                dr = patient2.ShowDialog();
              
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
        // Редактирование.  сохранение изменений
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
        //Удаление пациента
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (patientGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < patientGrid.SelectedItems.Count; i++)
                {
                    Patient patient1 = patientGrid.SelectedItems[i] as Patient;
                    if (patient1 != null)
                    {
                        db.Patients.Remove(patient1);
                    }
                } System.Windows.Forms.MessageBox.Show("Запись пациента удалена!");
            }
            db.SaveChanges();
            
        }

        //Добавление пациента
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DialogResult dr = new DialogResult();
            PatientAdd patient2 = new PatientAdd();
            dr = patient2.ShowDialog();

            Int64 number;
            if (patient2.cancelFlag == true)
                return;
            else
            {
                Patient patient = new Patient();
                patient.Name = patient2.textBox1.Text;
                patient.Gender = patient2.comboBox1.SelectedItem.ToString();
                patient.Age = patient2.textBox2.Text;
                patient.Adress = patient2.textBox3.Text;
                bool result = Int64.TryParse(patient2.textBox4.Text, out number);
                if (result)
                {
                    patient.Phone = number;
                }
                else { System.Windows.Forms.MessageBox.Show("Неправильно введён номер телефона!"); return; }

                db.Patients.Add(patient);
                db.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Новый пациент  добавлен!");
            }

        }
    }
}
