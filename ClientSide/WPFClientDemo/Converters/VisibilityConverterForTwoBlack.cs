﻿using Backgammon.PieceFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Globalization;

namespace WPFClientDemo.Converters
{
   public class VisibilityConverterForTwoBlack : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<IPiece> blackPieces = (List<IPiece>)value;
            if (blackPieces.Count > 1)
            {
                return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

      

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        
    }
}
