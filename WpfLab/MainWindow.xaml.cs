using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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


namespace WpfLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            ReadFile();
        }
        private void ReadFile()
        {
            DialogService dialogService = new DialogService();
            dialogService.OpenFileDialog();
            TestLabel.Content = "";
            try
            {
                foreach (string information in File.ReadLines(dialogService.FilePath))
                {
                    if (information == null)
                    {
                        break;
                    }
                    TestLabel.Content += information + "\n";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
