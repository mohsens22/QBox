﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace QBox.Converters
{
    class IsdoneToGlyphConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            int a = (int)value;
            string x = "";
            switch (a)
            {
                case 0:
                    {
                        x = "";
                        break;
                    }
                case 1:
                    {
                        x = "";
                        break;
                    }
                case 2:
                    {
                        x = "";
                        break;
                    }
                default:
                    break;
            }

            return x;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
