using LienNgoc.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LienNgoc.BusinessLogicLayer
{
    public class NhomBLL
    {
        private LienNgocDataContext dbContext;
        public NhomBLL()
        {
            dbContext = new LienNgocDataContext();
        }

        public List<Nhom> LoadNhomByID(int ID)
        {
            var result = from nhom in dbContext.Nhoms
                         where nhom.MaNhom == ID
                         select nhom;
            return result.ToList();
        }
    }
}
