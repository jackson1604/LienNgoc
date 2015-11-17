using LienNgoc.BusinessLogicLayer;
using LienNgoc.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace LienNgoc.PresentationLayer
{
    /// <summary>
    /// Interaction logic for NhanVienWindow.xaml
    /// </summary>
    public partial class NhanVienWindow : Window
    {
        private NhanVienBLL bll;
        private List<int> lstSelectionNhanVien;
        public NhanVienWindow()
        {
            InitializeComponent();
            bll = new NhanVienBLL();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(bll.LoadAllNhanVien().Count > 0)
            {
                DataGrid_NhanVien.ItemsSource = bll.LoadAllNhanVien();
                lstSelectionNhanVien = new List<int>();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Button_NhanVien_Them_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_NhanVien_CapNhat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_NhanVien_Xoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(lstSelectionNhanVien.Count > 0)
                {
                    int count = 0;
                    foreach (int item in lstSelectionNhanVien)
                    {
                        bll.DeleteNhanVien(item);
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên để xóa .\nVui lòng thử lại.",
                        "Thông tin Xóa",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hành động Xóa thất bại .\nVui lòng thử lại.",
                    "Thông tin Xóa",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DataGrid_NhanVien_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            //Console.WriteLine("Edit");
            FrameworkElement element = DataGrid_NhanVien.Columns[12].GetCellContent(e.Row);
            if(element.GetType() == typeof(CheckBox))
            {
                if(((CheckBox)element).IsChecked == true)
                {
                    FrameworkElement cellMaNhanVien = DataGrid_NhanVien.Columns[0].GetCellContent(e.Row);
                    int MaNhanVien = Convert.ToInt32(((TextBlock)cellMaNhanVien).Text);
                    lstSelectionNhanVien.Add(MaNhanVien);
                }
            }
        }

        private void TextBox_NhanVien_SearchNhanVien_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Qua cham
            ICollectionView view = CollectionViewSource.GetDefaultView(DataGrid_NhanVien.ItemsSource);
            view.Filter = m => ((NhanVien)m).TenNhanVien.ToLower().Contains(TextBox_NhanVien_SearchNhanVien.Text.ToLower());
        }
    }
}
