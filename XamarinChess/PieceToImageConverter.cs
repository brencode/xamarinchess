using System;
using System.Globalization;
using Xamarin.Forms;
using XamarinChess.Model;

namespace XamarinChess.Converters
{
    public class PieceToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Piece piece)
            {
                // Get the specified piece name from the PieceType property's value
                string pieceName = Enum.GetName(typeof(PieceType), piece.PieceType).ToLower();
                // use white pieces for the player
                if (piece.IsPlayer)
                {
					switch (piece.PieceType)
					{
                        case PieceType.Pawn:
                            return pieceName + "_" + "white";
                            // TODO: add additional piece support
                        default:
                            return string.Empty;
					}
                }
                // use black pieces for the AI
                else
                {
                    switch (piece.PieceType)
                    {
                        case PieceType.Pawn:
                            return pieceName + "_" + "black";
                        default:
                            return string.Empty;
                    }
                }
            }
            else
            {
                return string.Empty;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
