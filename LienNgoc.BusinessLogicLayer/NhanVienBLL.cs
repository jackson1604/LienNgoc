using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using LienNgoc.DataAccessLayer;
using System.Security.Cryptography;
using System.Configuration;
using System.Xml;

namespace LienNgoc.BusinessLogicLayer
{
    public class NhanVienBLL
    {
        private NhanVienDAO dao;
        private LienNgocDataContext dbContext;
        public NhanVienBLL()
        {
            dao = new NhanVienDAO();
            dbContext = new LienNgocDataContext();
        }

        public int? CheckLogin(NhanVien _nhanVien)
        {
            int? result = -1;
            dbContext.usp_LienNgoc_NhanVien_CheckLogin(
                _nhanVien.TenDangNhap, _nhanVien.MatKhau, ref result);
            return result;
        }

        public int InsertNhanVien(NhanVien _nhanVien)
        {
            //TenDangNhap,TenNhanVien,MatKhau,
            // NgaySinh,GioiTinh,DienThoai,DiaChi,
            //NgayTao,LanDNCuoi,LanDoiMKCuoi,BiKhoa,MaNhom
            return dbContext.usp_LienNgoc_NhanVien_InsertNhanVien(
                _nhanVien.TenDangNhap,
                _nhanVien.TenNhanVien,
                _nhanVien.MatKhau,
                _nhanVien.NgaySinh,
                _nhanVien.GioiTinh,
                _nhanVien.DienThoai,
                _nhanVien.DiaChi,
                _nhanVien.NgayTao,
                _nhanVien.LanDNCuoi,
                _nhanVien.LanDoiMKCuoi,
                _nhanVien.BiKhoa,
                _nhanVien.MaNhom);
        }

        public  void DeleteNhanVien(int _ID)
        {
            NhanVien _nhanVien = new NhanVien
            {
                MaNhanVien = _ID
            };
            if(LoadNhanVienByID(_ID).Count > 0)
            {
                var result = (from nv in dbContext.GetTable<NhanVien>()
                             where nv.MaNhanVien == _nhanVien.MaNhanVien
                             select nv).SingleOrDefault();
                dbContext.NhanViens.DeleteOnSubmit(result);
                dbContext.SubmitChanges();
            }

        }

        public List<NhanVien> LoadAllNhanVien()
        {
            var result = from nhanvien in dbContext.NhanViens
                         select nhanvien;
            return result.ToList();
        }

        public List<NhanVien> LoadNhanVienByID(int _ID)
        {
            var result = from nhanvien in dbContext.NhanViens
                         where nhanvien.MaNhanVien == _ID
                         select nhanvien;
            return result.ToList();
        }

        public static string getMD5Hash(string input)
        {
            // tao the hien MD5CryptoServiceProvider
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            // Convert string to byte
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static bool CheckConnectionString()
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["LienNgocConnString"].ConnectionString;
                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static void ChangeConnectionString(string con)
        {
            //updating config file
            XmlDocument XmlDoc = new XmlDocument();
            //Loading the Config file
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings")
                {
                    //setting the coonection string
                    xElement.FirstChild.Attributes[1].Value = con;
                }
            }
            //writing the connection string in config file
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        public static List<KeyValuePair<string,string>> GetConnectionString()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["LienNgocConnString"].ConnectionString);
            List<KeyValuePair<string, string>> connectionStringList = new List<KeyValuePair<string, string>>();
            connectionStringList.Add(new KeyValuePair<string, string>("DataSource", sb.DataSource));
            connectionStringList.Add(new KeyValuePair<string, string>("Initial Catalog", sb.InitialCatalog));
            if(sb.IntegratedSecurity)
            {
                connectionStringList.Add(new KeyValuePair<string, string>("Integrated Security", sb.IntegratedSecurity.ToString()));

            }
            else if(sb.UserID != null && sb.Password != null)
            {
                connectionStringList.Add(new KeyValuePair<string, string>("User ID", sb.UserID));
                connectionStringList.Add(new KeyValuePair<string, string>("Password", sb.Password));
            }
            return connectionStringList;

        }
    }
}
