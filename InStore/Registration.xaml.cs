using InStore.Model;
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

namespace InStore
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            Role.ItemsSource = AppData.db.Категория_Пользователя.ToList();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();

            users.Login = LoginTXB.Text;
            users.Password = PasswordTXB.Password;

            var CurrentRole = Role.SelectedItem as Категория_Пользователя;
            users.id_Категории_Пользователя = CurrentRole.id_Категории_пользователя;   

            AppData.db.Users.Add(users);
            AppData.db.SaveChanges();
            MessageBox.Show("Пользователь успешно зарегистрирован!");

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
