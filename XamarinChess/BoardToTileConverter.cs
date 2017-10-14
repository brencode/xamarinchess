using System;
using System.Globalization;
using Xamarin.Forms;
using XamarinChess.Model;
using System.Collections.Generic;
using System.Linq;
using XamarinChess.ViewModels;

namespace XamarinChess.Converters
{
    public class BoardToTileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            ChessBoard board = value as ChessBoard;
            string s = parameter as string;

            // split the string into a row a column
            IEnumerable<int> indexes = s.Split('.').Select(index => int.Parse(index));
            Tile tile = board.Tiles[indexes.First()][indexes.Last()];
            return tile;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
