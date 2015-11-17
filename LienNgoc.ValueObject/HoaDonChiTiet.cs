using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class HoaDonChiTiet
    {
        public HoaDon MaHoaDon { get; set; }
        public Thuoc MaThuoc { get; set; }
        public int SoLuong { get; set; }
    }
}
