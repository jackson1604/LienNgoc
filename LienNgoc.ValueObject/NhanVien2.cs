using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class NhanVien2
    {
        public int MaNhanVien { get; set; }
        public string TenDangNhap { get; set; }
        public string TenNhanVien { get; set; }
        public string MatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime LanDangNhapCuoi { get; set; }
        public DateTime LanDoiMatKhauCuoi { get; set; }
        public bool BiKhoa { get; set; }
        public Nhom MaNhom { get; set; }
    }
}
