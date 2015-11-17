using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using LienNgoc.DataAccessLayer;

namespace LienNgoc.BusinessLogicLayer
{
    public class DonViTinhBLL
    {
        private DonViTinhDAO dao;
        public DonViTinhBLL()
        {
            dao = new DonViTinhDAO();
        }

        //public IList<DonViTinh> GetAllDonViTinh()
        //{
        //    return dao.GetAllDonViTinh();
        //}

        //public DonViTinh GetDonViTinhByID(int ID)
        //{
        //    return dao.GetDonViTinhByID(ID);
        //}

        //public void InsertDonViTinh(DonViTinh _donViTinh)
        //{
        //    dao.InsertDonViTinh(_donViTinh);
        //}

        //public int UpdateDonViTinh(DonViTinh _donViTinh)
        //{
        //    return dao.UpdateDonViTinh(_donViTinh);
        //}

        //public int DeleteDonViTinh(DonViTinh _donViTinh)
        //{
        //    return dao.DeleteDonViTinh(_donViTinh);
        //}
    }
}
