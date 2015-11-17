using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LienNgoc.ValueObject
{
    public class DonViTinh
    {
        public DonViTinh(int MaDonViTinh, string TenDonViTinh)
        {
            this.MaDonViTinh = MaDonViTinh;
            this.TenDonViTinh = TenDonViTinh;
        }

        public DonViTinh()
        {

        }

        public int MaDonViTinh { get; set; }
        public string TenDonViTinh { get; set; }
    }
}
