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
using WPFdoga_FR_12B.datas;
using WPFdoga_FR_12B.view;

namespace WPFdoga_FR_12B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Show show = new Show();
        ShowDatas showDatas = new ShowDatas();

        public MainWindow()
        {
            InitializeComponent();
            MainPage.Navigate(showDatas);
            var list = show.ReadBooks();
            showDatas.ItemsSource = list;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainPage.Navigate(showDatas);
            var list = show.ReadBooks();
            showDatas.ItemsSource = list;
        }
    }
}
