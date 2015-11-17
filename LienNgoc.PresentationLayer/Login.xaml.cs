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
using System.Windows.Shapes;
using LienNgoc.BusinessLogicLayer;
using System.Configuration;
using LienNgoc.DataAccessLayer;

namespace LienNgoc.PresentationLayer
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private NhanVienBLL bll;
        private LienNgocDataContext dbContext;
        private NhanVien nhanvien;
        public Login()
        {
            InitializeComponent();
            bll = new NhanVienBLL();
            dbContext = new LienNgocDataContext();
            nhanvien = new NhanVien();
            InitializeConnectionString();
        }

        //private void DongYButton_Click(object sender, RoutedEventArgs e)
        //{
        //    nhanvien.TenDangNhap = TenDangNhapTextBox.Text;

        //    nhanvien.MatKhau = NhanVienBLL.getMD5Hash(MatKhauPasswordBox.Password);

        //    if(bll.CheckLogin(nhanvien))
        //    {
        //        Console.WriteLine(nhanvien.TenDangNhap);
        //        Console.WriteLine(nhanvien.MatKhau);
        //        //MessageBox.Show("Đăng nhập thành cmn công", "Thông tin đăng nhập", MessageBoxButton.OK, MessageBoxImage.Information);
        //        MainWindow mw = new MainWindow();
        //        mw.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Đăng nhập thất bại", "Thông tin đăng nhập", MessageBoxButton.OK, MessageBoxImage.Information);
        //        MatKhauPasswordBox.Password = null;
        //    }

        //}

        //private void TuChoiButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Shutdown();

        //}


        //private void TestConnectionSettingButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if(NhanVienBLL.CheckConnectionString())
        //    {
        //        MessageBox.Show("Kết nối thành công", "Thông tin kết nối", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    MessageBox.Show("Kết nối thất bại.\nVui lòng thử lại", "Thông tin kết nối", MessageBoxButton.OK, MessageBoxImage.Error);
        //}

        //private void DongYSettingButton_Click(object sender, RoutedEventArgs e)
        //{
        //    ////Data Source=localhost\sqlexpress;Initial Catalog=LIEN_NGOC;Integrated Security=True
        //    ////Data Source=localhost\sqlexpress;Initial Catalog=LIEN_NGOC;User ID=sa;Password=***********
        //    //StringBuilder sb = new StringBuilder("Data Source=");
        //    //sb.Append(ServerNameTextBox.Text);
        //    //sb.Append(";Initial Catalog=");
        //    //sb.Append("LIEN_NGOC");
            
        //    //if(AuthenticationTypeComboBox.SelectedIndex == 0)
        //    //{
        //    //    sb.Append(";User ID=");
        //    //    sb.Append(LoginTextBox.Text);
        //    //    sb.Append(";Password=");
        //    //    sb.Append(MatKhauSQLPasswordBox.Password);
        //    //}
        //    //else
        //    //{
        //    //    sb.Append(";Integrated Security=True");

        //    //}

        //    //Console.WriteLine(sb.ToString());
        //    //NhanVienBLL.ChangeConnectionString(sb.ToString());
        //}

        private void InitializeConnectionString()
        {
            //ServerNameTextBox.Text = NhanVienBLL.GetConnectionString().I

        }

        private void Button_DangNhap_Click(object sender, RoutedEventArgs e)
        {
            //dbContext.TenD = TextBox_TenDangNhap.Text;

            //dbContext.MatKhau = NhanVienBLL.getMD5Hash(PasswordBox_MatKhau.Password);
            nhanvien.TenDangNhap = TextBox_TenDangNhap.Text.Trim();
            nhanvien.MatKhau = NhanVienBLL.getMD5Hash(PasswordBox_MatKhau.Password);

            
            if (bll.CheckLogin(nhanvien) == 1)
            {
                Console.WriteLine(nhanvien.TenDangNhap);
                Console.WriteLine(nhanvien.MatKhau);
                //MessageBox.Show("Đăng nhập thành cmn công", "Thông tin đăng nhập", MessageBoxButton.OK, MessageBoxImage.Information);
                MainWindow mw = new MainWindow();
                mw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.\nVui lòng nhập lại.",
                    "Thông tin đăng nhập",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                PasswordBox_MatKhau.Password = null;
            }

        }

        private void Button_TuChoi_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}