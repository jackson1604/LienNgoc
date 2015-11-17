using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class PhieuNhap
    {
        public int SoPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public NhanVien2 MaNhanVien { get; set; }
        public string LyDoNhap { get; set; }
    }
}
