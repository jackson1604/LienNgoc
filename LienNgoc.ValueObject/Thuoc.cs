using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class Thuoc
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string TenVietTat { get; set; }
        public string CongDung { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DonViTinh MaDonVi { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public LoaiThuoc MaLoaiThuoc { get; set; }
    }
}
