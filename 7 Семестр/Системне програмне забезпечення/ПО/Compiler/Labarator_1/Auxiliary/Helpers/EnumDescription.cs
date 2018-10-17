﻿using System.ComponentModel;
using System.Reflection;

namespace Labarator_1.Auxiliary
{
    public class EnumDescription
    {
        public static string Description(object value )
        {
     
                FieldInfo fi = value.GetType( ).GetField(value.ToString( ));

                DescriptionAttribute[] attributes =
                    (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes != null && attributes.Length > 0)
                    return attributes[0].Description;
                else
                    return value.ToString( );
      
        }
    }
}
