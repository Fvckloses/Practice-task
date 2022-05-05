using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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

namespace task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBTur_firm.db");
            connection.Open();
            SQLiteDataAdapter ad = new SQLiteDataAdapter();
            SQLiteCommand cmd = new SQLiteCommand();
            String str = "SELECT idTour,TourName,TourPrice,TourInfo FROM Tours";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            cmd.Connection = connection;
            DataSet ds = new DataSet();
            ad.Fill(ds);
            ListViewDB.ItemsSource = ds.Tables[0].DefaultView;

            str = "SELECT idTourists,TouristsLastName,TouristsFirstName,TouristsMidleName FROM Tourists";
            cmd.CommandText = str;
            ad.SelectCommand = cmd;
            cmd.Connection = connection;
            DataSet ds1 = new DataSet();
            ad.Fill(ds1);
            ListViewDBTourists.ItemsSource = ds1.Tables[0].DefaultView;
            connection.Close();
        }

        private void Addtour(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=E:\Практика\C#\Practice\PracticeTasks\Practice_30\task1\DBTur_firm.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);
            int idTour = int.Parse(TextBoxAdd.Text.Split()[0]);
            string TourName = TextBoxAdd.Text.Split()[1];
            int TourPrice = int.Parse(TextBoxAdd.Text.Split()[2]);
            string TourInfo = TextBoxAdd.Text.Split()[3];
            String str = $"INSERT INTO Tours (idTour, Tourname, TourPrice, TourInfo) VALUES ({idTour}, '{TourName}', {TourPrice}, '{TourInfo}')";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        private void DeleteSelected(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBTur_firm.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);
            sString str = $"DELETE FROM Tours WHERE idTour = {Convert.ToInt32(DeleteTextBox.Text)}";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Addtourist(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBTur_firm.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);
            int idTourist = int.Parse(TextBoxAddTourist.Text.Split()[0]);
            string TouristsLastName = TextBoxAddTourist.Text.Split()[1];
            string TouristsFirstName = TextBoxAddTourist.Text.Split()[2];
            string TouristsMidleName = TextBoxAddTourist.Text.Split()[3];
            String str = $"INSERT INTO Tourists (idTourists,TouristsLastName,TouristsFirstName,TouristsMidleName) VALUES ({idTourist}, '{TouristsLastName}', '{TouristsFirstName}', '{TouristsMidleName}')";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void ChangeById(object sender, RoutedEventArgs e)
        {
            SQLiteConnection connection = new SQLiteConnection(@"Data Source=DBTur_firm.db");
            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand(connection);
            int idTourist = int.Parse(ChangeTextBox.Text.Split()[0]);
            string TouristsLastName = ChangeTextBox.Text.Split()[1];
            string TouristsFirstName = ChangeTextBox.Text.Split()[2];
            string TouristsMidleName = ChangeTextBox.Text.Split()[3];
            String str = $"UPDATE Tourists SET TouristsLastName = '{TouristsLastName}', TouristsFirstName='{TouristsFirstName}', TouristsMidleName='{TouristsMidleName}' WHERE idTourists = {idTourist};";
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
