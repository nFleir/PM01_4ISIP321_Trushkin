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

namespace PM01_4IPIP321_Trushkin
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите выйти?", "Управление жилым фондом", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel= false;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.NavigationService.CanGoBack) MainFrame.NavigationService.GoBack();
            EmployersButton.IsEnabled = true;
            AddressesButton.IsEnabled = true;
            RequestsButton.IsEnabled = true;
        }

        private void EmployersButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.EmployersPage());
            EmployersButton.IsEnabled = false;
            AddressesButton.IsEnabled = true;
            RequestsButton.IsEnabled = true;
        }

        private void AddressesButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.AddressesPage());
            EmployersButton.IsEnabled = true;
            AddressesButton.IsEnabled = false;
            RequestsButton.IsEnabled = true;
        }

        private void RequestsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Pages.RequestsPage());
            EmployersButton.IsEnabled = true;
            AddressesButton.IsEnabled = true;
            RequestsButton.IsEnabled = false;
        }
    }
}