using System.Windows;
using System.Windows.Controls;

namespace Gushchina_Authorization.Pages
{
    public partial class Autho : Page
    {
        public Autho()
        {
            InitializeComponent();
        }

        private void BtnEnterGuests_Click(object sender, RoutedEventArgs e)
        {
            // Переходим на страницу клиента без авторизации.
            NavigationService.Navigate(new Client());
        }

        private void BtnEnter_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем, заполнены ли оба поля.
            if (string.IsNullOrWhiteSpace(TxtLogin.Text) ||
                string.IsNullOrWhiteSpace(PswPassword.Password))
            {
                MessageBox.Show(
                    "Введите логин и пароль.",
                    "Не все данные заполнены",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            MessageBox.Show(
                "Данные введены. Проверка пользователя будет добавлена в следующей работе.",
                "Авторизация",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}