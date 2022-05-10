using ApplicationContextDB;
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

namespace task1
{
    public partial class MainWindow : Window
    {
        private readonly ApplicationContext _context;

        public MainWindow(ApplicationContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void RefreshDB()
        {
            var tours = _context.Tours.ToList();
            var touristsInfo = _context.TouristsInfo.ToList();
            var tourists = _context.Tourists.ToList();
            DataGridTours.ItemsSource = tours;
            DataGridToursistsInfo.ItemsSource = touristsInfo;
            DataGridToursists.ItemsSource = tourists;
        }

        private void test_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshDB();
        }

        private void SelectByName(object sender, RoutedEventArgs e)
        {
            DataGridTours.ItemsSource = _context.Tours
                .Where(tours => tours.TourName == NameTextBox.Text)
                .ToList();
        }
        private void SelectByCity(object sender, RoutedEventArgs e)
        {
            DataGridToursists.ItemsSource = _context.Tourists
                .Where(toursists =>
                    toursists.TouristsInfo.City == CityTextBox.Text)
                .ToList();
        }
        private void SelectByFirstWordName(object sender, RoutedEventArgs e)
        {
            DataGridToursists.ItemsSource = _context.Tourists
               .Where(tourists => tourists.TouristsFirstName.StartsWith(FirstWordNameTextBox.Text))
                .ToList();
        }
        private void SelectByCost(object sender, RoutedEventArgs e)
        {
            DataGridTours.ItemsSource = _context.Tours
               .Where(tours =>
                    tours.TourPrice > int.Parse(CostBetween.Text.Split()[0]) && tours.TourPrice < Convert.ToInt32(CostBetween.Text.Split()[1]))
                .ToList();
        }
        private void UpdateDB(object sender, RoutedEventArgs e)
        {
            RefreshDB();
        }
    }
}
