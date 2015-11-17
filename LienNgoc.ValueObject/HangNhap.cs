using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class HangNhap
    {
        public int MaHangNhap { get; set; }
        public PhieuNhap SoPhieuNhap { get; set; }
        public Thuoc MaThuoc { get; set; }
        public int SoLuong { get; set; }
    }
}
