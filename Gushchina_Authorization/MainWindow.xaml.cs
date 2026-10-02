using System;
using System.Windows;
using Gushchina_Authorization.Pages;

namespace Gushchina_Authorization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // При запуске открываем страницу авторизации.
            FrmMain.Navigate(new Autho());
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            // Возвращаемся на предыдущую страницу, если она существует.
            if (FrmMain.CanGoBack)
            {
                FrmMain.GoBack();
            }
        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {
            // Показываем кнопку «Назад» только тогда,
            // когда действительно можно вернуться назад.
            BtnBack.Visibility = FrmMain.CanGoBack
                ? Visibility.Visible
                : Visibility.Hidden;
        }
    }
}