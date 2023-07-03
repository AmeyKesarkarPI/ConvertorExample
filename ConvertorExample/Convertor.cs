using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ConvertorExample
{
    public class Convertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is true)
            {
                parameter = "Active";
            }
            else
            {
                parameter = "InActive";
            }
            return parameter;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is "Active")
            {
                parameter = true;
            }
            else if (value is "InActive")
            {
                parameter = false;
            }
            return parameter;
        }
    }
}
