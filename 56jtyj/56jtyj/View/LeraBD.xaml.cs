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
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Entity;
using Microsoft.Win32;
using System.IO;
using _56jtyj.ModelDb;

namespace _56jtyj.View
{
    /// <summary>
    /// Логика взаимодействия для LeraBD.xaml
    /// </summary>
    public partial class LeraBD : Window
    {
        public LeraBD()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MaslovEntities Lera = new MaslovEntities();
            Lera.Sheet1_.Load();
            OpenBD.ItemsSource = Lera.Sheet1_.Local.ToBindingList();
            BD.Visibility = Visibility.Hidden;

        }
    }
}
