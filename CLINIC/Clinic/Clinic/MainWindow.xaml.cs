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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Clinic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClinicContext db;
        public MainWindow()
        {
            InitializeComponent();
            
            db = new ClinicContext();
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            db.Dispose();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PatientWindow patientWindow = new PatientWindow();
            patientWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PatientWindow patientWindow = new PatientWindow();
            patientWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            VisitWindow visitWindow = new VisitWindow();
            visitWindow.Show();
        }

        public static int GetTableCount(string tablename, string connStr = null)
        {
            //string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=usersdb;Integrated Security=True";
           string connectionString=@"data source=(localdb)\MSSQLLocalDB;Initial Catalog=clinic;Integrated Security=True"; 
            string stmt = string.Format("SELECT COUNT(*) FROM {0}", tablename);
            if (String.IsNullOrEmpty(connStr))
                connStr = connectionString;
            int count = 0;


            using (SqlConnection thisConnection = new SqlConnection(connStr))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count = (int)cmdCount.ExecuteScalar();
                }
            }
            return count;
        }

        
    }
}
