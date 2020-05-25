using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using _56jtyj.ModelDb;


namespace _56jtyj
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User user;
        MaslovEntities Lera;
        public MainWindow()
        {
            Lera = new MaslovEntities();
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = Loginn.Text;
            string password = Passwordd.Text;

            MaslovEntities Lera = new MaslovEntities();
            Lera.User.Load();

            var user = Lera.User
                .Where(u => u.Login == login && u.Password == password)
                .FirstOrDefault();
            if (user == null)
                MessageBox.Show("Вы ввели неверный логин или пароль. Пожалуйста, повторите попытку");
            if (user != null)
            {
                View.LeraBD window1 = new View.LeraBD();
                window1.Show();
            }
            

              
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            user = new User();
            user.Name = Name.Text;
            user.LastName = LastName.Text;
            user.Age = Convert.ToInt32(Age.Text);
            user.Login = LoginRegistr.Text;
            user.Password = PasswordRegistr.Text;
            Lera.User.Add(user);
            MessageBox.Show("Успешно зарегистрировались");
            Lera.SaveChanges();
           
        }
    }
}
