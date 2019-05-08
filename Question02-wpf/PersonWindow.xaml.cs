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
using Question02_wpf.Models;
using System.Net;
using Newtonsoft.Json;

namespace Question02_wpf
{
    /// <summary>
    /// Interaction logic for PersonWindow.xaml
    /// </summary>
    public partial class PersonWindow : Window
    {
        public PersonWindow()
        {
            InitializeComponent();
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);
                Person p1 = new Person();
                List<Person> data = JsonConvert.DeserializeObject<List<Person>>(json);
                Person.Content = p1.Display_Data(data);
            }
        }
    }
}
