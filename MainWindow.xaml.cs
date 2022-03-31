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

namespace Listview_2GUIs
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
        private void Window_Loaded(object sender, RoutedEventArgs e) => (sender as Window).Topmost = true;

        private void lv_GUI_1st_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lv_GUI_2nd_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btn_TestCommand_Click(object sender, RoutedEventArgs e)
        {
            
        }

    }

    public class Lv1st
    {
        public string s_Name="";
        public int i_Age;
    }
}
