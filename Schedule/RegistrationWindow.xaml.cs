using Microsoft.EntityFrameworkCore;
using Schedule.Models;
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
using System.Windows.Shapes;

namespace Schedule
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string lastName = lastNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string nickname = nicknameTextBox.Text;
            string password = passwordTextBox.Text;

            User user = new User
            {
                Name = firstName,
                Surname = lastName,
                Patronymic = middleName,
                NickName = nickname,
                Password = password
            };

            var connection = new DbContextOptionsBuilder<UsersContext>();
            connection.UseSqlServer(@"Server=DYWKAT\SQLEXPRESS;Database=Users;Trusted_Connection=True;Encrypt=False");


            using (var users = new UsersContext(connection.Options))
            {
                users.Users.Add(user); 
                users.SaveChanges(); 
            }

            MessageBox.Show("Вы успешно зарегистрированы!");
        }
    }
}

