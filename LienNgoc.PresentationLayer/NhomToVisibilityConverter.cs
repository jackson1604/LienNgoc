using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using LienNgoc.BusinessLogicLayer;

namespace LienNgoc.PresentationLayer
{
    class NhomToVisibilityConverter : IValueConverter
    {
        private NhomBLL bll;
        public NhomToVisibilityConverter()
        {
            bll = new NhomBLL();
        }
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            
            int ID = System.Convert.ToInt32(value);
            var result = from nhom in bll.LoadNhomByID(ID)
                         select nhom.TenNhom;
            return result.First();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
