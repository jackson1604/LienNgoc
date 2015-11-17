using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LienNgoc.BusinessLogicLayer;

namespace LienNgoc.PresentationLayer
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_HoSo_DangXuat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new Login().Show();
        }

        private void MenuItem_HoSo_Thoat_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_MainWindow_System_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
