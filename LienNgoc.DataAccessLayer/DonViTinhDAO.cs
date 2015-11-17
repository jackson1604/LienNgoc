using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LienNgoc.DataAccessLayer
{
    public class DonViTinhDAO
    {
        /*public DonViTinhDAO()
        {
            SqlHelper.GetConnection();
        }

        /// <summary>
        /// Lấy thông tin về đơn vị tinh
        /// </summary>
        /// <returns>IList DonViTinh</returns>
        public IList<DonViTinh> GetAllDonViTinh()
        {
            string spName = "usp_LienNgoc_DonViTinh_GetList";
            DataTable dt = SqlHelper.ExecuteQuery(spName, (int)SqlHelper.SqlType.StoredProcedure);
            return MakeDonViTinh(dt);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DonViTinh GetDonViTinhByID(int ID)
        {
            SqlParameter[] _params = 
            {
                new SqlParameter("@ID", SqlDbType.Int)
            };
            _params[0].Value = ID;
            string spName = "usp_LienNgoc_DonViTinh_GetListByID";
            DataTable dt = SqlHelper.ExecuteQuery(spName, (int)SqlHelper.SqlType.StoredProcedure, _params);
            return MakeDonViTinh(dt.Rows[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_donViTinh"></param>
        public void InsertDonViTinh(DonViTinh _donViTinh)
        {
            SqlParameter[] _params = 
            {
                new SqlParameter("@MaDonViTinh", SqlDbType.Int),
                new SqlParameter("@TenDonViTinh", SqlDbType.NVarChar)
            };
            _params[0].Direction = ParameterDirection.Output;
            _params[1].Value = _donViTinh.TenDonViTinh;

            int newID = SqlHelper.ExecuteNonQuery("usp_LienNgoc_DonViTinh_Insert", (int)SqlHelper.SqlType.StoredProcedure, _params);
            _donViTinh.MaDonViTinh = newID;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_donViTinh"></param>
        /// <returns></returns>
        public int UpdateDonViTinh(DonViTinh _donViTinh)
        {
            SqlParameter[] _params = 
            {
                new SqlParameter("@MaDonViTinh", SqlDbType.Int),
                new SqlParameter("@TenDonViTinh", SqlDbType.NVarChar)
            };
            _params[0].Value = _donViTinh.MaDonViTinh;
            _params[1].Value = _donViTinh.TenDonViTinh;

            return SqlHelper.ExecuteNonQuery("usp_LienNgoc_DonViTinh_Update", (int)SqlHelper.SqlType.StoredProcedure, _params);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_donViTinh"></param>
        /// <returns></returns>
        public int DeleteDonViTinh(DonViTinh _donViTinh)
        {
            SqlParameter[] _params = 
            {
                new SqlParameter("@MaDonViTinh", SqlDbType.Int),
            };
            _params[0].Value = _donViTinh.MaDonViTinh;
            return SqlHelper.ExecuteNonQuery("usp_LienNgoc_DonViTinh_Delete", (int)SqlHelper.SqlType.StoredProcedure, _params);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_dt"></param>
        /// <returns></returns>
        public IList<DonViTinh> MakeDonViTinh(DataTable _dt)
        {
            IList<DonViTinh> list = new List<DonViTinh>();
            foreach (DataRow row in _dt.Rows)
            {
                list.Add(MakeDonViTinh(row));
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public DonViTinh MakeDonViTinh(DataRow row)
        {
            int MaDonViTinh = int.Parse(row["MaDonViTinh"].ToString());
            string TenDonViTinh = row["TenDonViTinh"].ToString();
            return new DonViTinh(MaDonViTinh, TenDonViTinh);
        }*/
    }
}
