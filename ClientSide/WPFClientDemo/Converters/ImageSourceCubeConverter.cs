using Backgammon;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFClientDemo.Converters
{
    public class ImageSourceCubeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            switch ((int)value)
            {
                case 1:
            return @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\1.png";
                case 2:
                    return @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\2.png";
                case 3:
                 return   @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\3.png";
                case 4:
                    return @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\4.png";
                case 5:
                    return @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\5.png";
                case 6:
                    return @"C:\Users\hen\Desktop\ClientSideTester\WPFClientDemo\Images\6.png";
                default:
                    return new Exception("something is wrong with the steps values");
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
