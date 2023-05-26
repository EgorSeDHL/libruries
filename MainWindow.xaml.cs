using FuncLibr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Eight_prac_C_sharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public static List<string> list = new List<string>();
        public int i = 1;
        public int j = 1;
        public MainWindow()
        {
            InitializeComponent();
            list_box.ItemsSource = list.ToArray();
        }

        private void serialize_btn_Click(object sender, RoutedEventArgs e)
        {
            Class1.MySerialize(list);
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            list.Add(name_box.Text);
            list_box.ItemsSource = list.ToArray();
        }

        private void deserialize_btn_Click(object sender, RoutedEventArgs e)
        {
            list = Class1.MyDeserialize<List<string>>();
            list_box.ItemsSource = list.ToArray();

        }

        private void theme_btn_Click(object sender, RoutedEventArgs e)
        {
            if (i == 2)
            {
                App.Theme = "DarkTheme";
                i--;
            }
            else
            {

                App.Theme = "OrangeTheme";
                i++;
            }
        }

        private void language_btn_Click(object sender, RoutedEventArgs e)
        {
            if (i == 2)
            {
                App.Language = "EnglishLanguage";
                i--;
            }
            else
            {

                App.Language = "RussianLanguage";
                i++;
            }
        }
    }
}
