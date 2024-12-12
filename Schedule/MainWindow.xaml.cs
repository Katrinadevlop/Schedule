using Microsoft.EntityFrameworkCore;
using Schedule.DB;
using Schedule.Models;
using System.Text;
using System.Drawing; 
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
        private string captchaCode;

        public MainWindow()
        {
            InitializeComponent();
            GenerateCaptcha(); 
        }

        private void GenerateCaptcha()
        {
            var captcha = new Captcha();
            captchaCode = captcha.Generate(); 
            Bitmap captchaImage = captcha.GetBitmap(); 

            pictureBoxCaptcha.Source = ConvertBitmapToImageSource(captchaImage); 
        }

        private ImageSource ConvertBitmapToImageSource(Bitmap bitmap)
        {
            using (var memoryStream = new System.IO.MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                return BitmapFrame.Create(memoryStream);
            }
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

            if (chaptaTextBox.Text == captchaCode)
            {
                MessageBox.Show("Капча введена правильно!");
            }
            else
            {
                MessageBox.Show("Неверный код капчи.");
                GenerateCaptcha(); 
            }
        }

        private void GoToRegistrationButton_Click(Object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }
    }
}