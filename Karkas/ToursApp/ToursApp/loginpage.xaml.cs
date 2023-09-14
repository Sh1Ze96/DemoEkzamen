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

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для loginpage.xaml
    /// </summary>
    public partial class loginpage : Page
    {
        public loginpage()
        {
            InitializeComponent();
        }
        private void Enter(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "root" && Password.Text == "12345")
                Manager.MainFrame.Navigate(new Admin());
        }
        private void Checked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            Password.Visibility = Visibility.Visible;
            Password.Text = passwordBox.Password; 
        }
        private void UnChecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            passwordBox.Visibility = Visibility.Collapsed;
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
