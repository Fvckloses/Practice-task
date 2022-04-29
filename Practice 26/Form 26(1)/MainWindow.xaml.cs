using Form_26_1_.InterFaces;
using Form_26_1_.models;
using Form_26_1_.Share;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Form_26_1_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;
        private IEnumerable<object> parkingg;

        public MainWindow()
        {
            InitializeComponent();
            _logger = LoggerFactory.Create(builder => builder.SetMinimumLevel
                            (LogLevel.Information)).CreateLogger<MainWindow>();
            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindCountryByName_Click(object sender, RoutedEventArgs e)
        {
            var country = _worker.FindBy(textBoxCountryName.Text);
            PrintCountry(country);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            PrintCountries(_worker.GetAll);
        }
        private void PrintCountries(Func<List<Parking>> getAll)
        {
            textBlockXMLFileContent.Text = "========Autos=======" + Environment.NewLine;
            foreach (var Parking in parkingg)
            {
                textBlockXMLFileContent.Text += Parking.ToString();
            }
        }
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDeleteCountryName.Text) || !string.IsNullOrWhiteSpace(textBoxDeleteCountryName.Text))
            {
                _worker.Delete(textBoxDeleteCountryName.Text);
                PrintCountries(_worker.GetAll);
            }
        }
        private void PrintCountry(Parking parkingg)
        {
            textBlockXMLFileContent.Text = "=======Parking========" + Environment.NewLine;
            textBlockXMLFileContent.Text += parkingg?.ToString() ?? "Parking not found";
        }
        private void textBoxCountryName_TextChanged(object sender)
        {
            if (string.IsNullOrEmpty(textBoxCountryName.Text))
            {
                PrintCountries(_worker.GetAll);
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory).Parent.Parent.FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents(.xml)|*.xml";
            var result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintCountries(_worker.GetAll);
            }
        }
    }
}
