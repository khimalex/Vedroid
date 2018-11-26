using System;
using Xamarin.Forms;

namespace Vedroid.ShopCalc
{
    public class DecimalConverter : IValueConverter
    {
        public Object Convert(Object value, Type targetType, Object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is Decimal)
            {
                return Decimal.Round((Decimal)value, 2).ToString();
            }

            return value;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, System.Globalization.CultureInfo culture)
        {
            if (Decimal.TryParse(value as String, System.Globalization.NumberStyles.Number | System.Globalization.NumberStyles.AllowDecimalPoint, culture, out Decimal dec))
            {
                return dec;
            }

            return value;
        }
    }
}
