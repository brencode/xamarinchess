using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Globalization;

namespace XamarinChess.Converters
{
    public class BackgroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool b = (bool)value;
            if (b)
                return Color.Yellow;
            else
                return Color.FromHex(parameter as string);
        }
            
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
