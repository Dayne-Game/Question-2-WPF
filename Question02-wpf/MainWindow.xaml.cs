using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Question02_wpf.Models;
using Newtonsoft.Json;

namespace Question02_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Personbtn_Click(object sender, RoutedEventArgs e)
        {
            PersonWindow wind = new PersonWindow();
            wind.Show();
        }

        private void Supervisorbtn_Click(object sender, RoutedEventArgs e)
        {
            SupervisorWindow super = new SupervisorWindow();
            super.Show();
        }
    }
}
