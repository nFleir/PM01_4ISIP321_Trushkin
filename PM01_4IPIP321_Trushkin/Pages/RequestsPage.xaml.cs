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

namespace PM01_4IPIP321_Trushkin.Pages
{
    /// <summary>
    /// Логика взаимодействия для RequestsPage.xaml
    /// </summary>
    public partial class RequestsPage : Page
    {
        public RequestsPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var Requests = Entities.GetContext().Requests.ToList();
            RequestGrid.ItemsSource = Requests;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddEditRequests(null));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AddEditRequests(RequestGrid.SelectedItem as Requests));
        }
    }
}
