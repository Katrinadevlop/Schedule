using Microsoft.EntityFrameworkCore;
using Schedule.DB;
using Schedule.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Schedule.DB.Connection;

namespace Schedule
{
    partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Connection connection = new Connection();
            connection.ConnectionFun();*/
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            string nickName = nicknameTextBox.Text;
            string password = passwordTextBox.Text;

            var connection = new DbContextOptionsBuilder<UsersContext>();
            connection.UseSqlServer(@"Server=DYWKAT\SQLEXPRESS;Database=Users;Trusted_Connection=True;Encrypt=False");
            using (var users = new UsersContext(connection.Options)) 
            { 
                var user = users.Users.FirstOrDefault(u => u.NickName == nickName && u.Password == password);
                if (user != null)
                    MessageBox.Show("Вы авторизованы!");
                else
                    MessageBox.Show("Такого пользователя нет в системе");
            }
        }

        private void GoToRegistrationButton_Click(Object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }
    }
}