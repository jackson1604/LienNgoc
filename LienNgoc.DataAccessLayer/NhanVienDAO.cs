using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;

namespace LienNgoc.DataAccessLayer
{
    public class NhanVienDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["LienNgocConnString"].ConnectionString;

        public int CheckLogin(NhanVien _nhanVien)
        {
            SqlParameter[] parameter = 
            {
                new SqlParameter("@TenDangNhap", SqlDbType.NVarChar, 30),
                new SqlParameter("@MatKhau", SqlDbType.NVarChar, 32),
                new SqlParameter("@Result", SqlDbType.Int)
            };
            parameter[0].Value = _nhanVien.TenDangNhap;
            parameter[1].Value = _nhanVien.MatKhau;
            parameter[2].Direction = ParameterDirection.Output;

            SqlHelper.ExecuteNonQuery(connectionString, CommandType.StoredProcedure, "usp_LienNgoc_NhanVien_CheckLogin", parameter);
            int result = (int)parameter[2].Value;
            return result;
        }
    }
}
