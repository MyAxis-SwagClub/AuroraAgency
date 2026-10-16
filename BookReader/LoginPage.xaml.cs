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

namespace BookReader
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    /// 

    
    public partial class LoginPage : Page
    {
        private void RegisterClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.NavigationService.Navigate(new RegisterPage());
                this.Title = "MAIDJASL;DAS";
            }
        }
        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
