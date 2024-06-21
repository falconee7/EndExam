using exam.controllers;
using exam.models;
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

namespace exam.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddRequest.xaml
    /// </summary>
    public partial class PageAddRequest : Page
    {
        private AddRequestController _addrequestController;
        private PageClient  _pageClient;
        public PageAddRequest()
        {
            InitializeComponent();
            _addrequestController = new AddRequestController();

            CmbClimateTechType.ItemsSource = DbConnection.Examentities.ClimateTechType.ToList();
            CmbClimateTechType.DisplayMemberPath = "Name";
            CmbClimateTechType.SelectedValuePath = "id";
            CmbClimateTechType.SelectedIndex = 0;
            _pageClient = new PageClient();
        }

        private void BtnAddRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                long climateTechTypeId = (long)CmbClimateTechType.SelectedValue;
                string climateTechModel = TxbClimateTechModel.Text;
                string problemDescryption = TxbProblemDescription.Text;
                _addrequestController.AddNewRequest(climateTechTypeId, climateTechModel, problemDescryption);
                MessageBox.Show("Запрос успешно добавлен !", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                _pageClient.FillGridClientRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameNavigate.frame.GoBack();
        }
    }
}
