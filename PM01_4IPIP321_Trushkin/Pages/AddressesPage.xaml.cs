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
    /// Логика взаимодействия для AddressesPage.xaml
    /// </summary>
    public partial class AddressesPage : Page
    {
        public AddressesPage()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var addresses = Entities.GetContext().Buildings.ToList();
            AddressesGrid.ItemsSource = addresses;
        }
    }
}
