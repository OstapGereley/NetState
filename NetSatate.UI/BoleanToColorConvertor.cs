using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace NetSatate.UI
{
    class BoleanToColorConvertor : MarkupExtension, IValueConverter
    {
        private BoleanToColorConvertor _convertor;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? boolValue = (bool?)value;

            switch(boolValue)
            {
                case false: return new SolidColorBrush(Colors.Red);
                case true: return new SolidColorBrush(Colors.Green);

                default: return new SolidColorBrush(Color.FromRgb(83, 83, 83));
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
           if(_convertor != null)
            {
                return _convertor;
            }
           else
            {
                _convertor = new BoleanToColorConvertor();
                return _convertor;
            }
        }
    }
}
