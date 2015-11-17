using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public NhanVien2 MaNhanVien { get; set; }
        public DateTime NgayBan { get; set; }
        public double TongThanhTien { get; set; }

    }
}
