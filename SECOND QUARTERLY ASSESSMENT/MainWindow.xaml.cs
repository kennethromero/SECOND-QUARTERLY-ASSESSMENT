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

using System.Net;

namespace SECOND_QUARTERLY_ASSESSMENT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var url = "http://newsapi.org/v2/top-headlines?country=ru&category=business&apiKey=API_KEY" +
             "country = ru&" +
             "category = business" +
             "apiKey= 42a9d08a5a02488491bb873c92a613d3";

            var json = new WebClient().DownloadString(url);

            Console.WriteLine(json);


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
