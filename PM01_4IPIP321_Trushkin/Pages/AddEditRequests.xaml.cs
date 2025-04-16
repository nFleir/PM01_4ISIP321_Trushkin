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
    /// Логика взаимодействия для AddEditRequests.xaml
    /// </summary>
    public partial class AddEditRequests : Page
    {
        private Requests request = new Requests();

        public AddEditRequests(Requests requests)
        {
            InitializeComponent();
            if (requests != null)
            {
                request = requests;
                LabelAddEdit.Content = "Изменение заявки";
            }

            DataContext = request;

            LoadData();
        }

        private void LoadData()
        {
            CitizenBox.ItemsSource = Entities.GetContext().Citizens.ToList();
            CitizenBox.DisplayMemberPath = "LastName";
            CitizenBox.SelectedValuePath = "ID";

            EmployerBox.ItemsSource = Entities.GetContext().Employers.ToList();
            EmployerBox.DisplayMemberPath = "LastName";
            EmployerBox.SelectedValuePath = "ID";

            StatusBox.ItemsSource = Entities.GetContext().Statuses.ToList();
            StatusBox.DisplayMemberPath = "StatusName";
            StatusBox.SelectedValuePath = "ID";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void AddEditButton_Click(object sender, RoutedEventArgs e)
        {
            

            StringBuilder errors = new StringBuilder();


            if (string.IsNullOrWhiteSpace(request.Description)) { errors.AppendLine("Вы не ввели запрос"); }

            if (CitizenBox.SelectedValue == null) { errors.AppendLine("Выберите жителя!"); }
            else
            {
                request.CitizenID = (int)CitizenBox.SelectedValue;
            }
            if (EmployerBox.SelectedValue == null) { errors.AppendLine("Выберите работника!"); }
            else
            {
                request.EmployerID = (int)EmployerBox.SelectedValue;
            }
            if (StatusBox.SelectedValue == null) { errors.AppendLine("Выберите статуса!"); }
            else
            {
                request.StatusID = (int)CitizenBox.SelectedValue;
            }

            if(errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            Entities.GetContext().Requests.Add(request);

            try
            {
                Entities.GetContext().SaveChanges();
                MessageBox.Show("Успешно сохранено!");
                NavigationService.Navigate(new Pages.RequestsPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
