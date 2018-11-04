using System;
using System.Globalization;
using System.Windows.Data;

namespace Labarator_3.Auxiliary
{
    public sealed class ConvertEnumToDescription : IValueConverter
    {

        public object Convert( object values, Type targetType, object parameter, CultureInfo culture )
        {
            if (values != null)
                return EnumDescription.Description(values);
            return null;
        }

        public object ConvertBack( object value, Type targetTypes, object parameter, CultureInfo culture )
        {
            return null;
        }
    }
}

