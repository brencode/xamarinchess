using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinChess.Model
{
    public class ChessBoard : ModelObject
    {
        public ChessBoard(List<List<Tile>> tiles)
        {
            Tiles = tiles;
        }


        private List<List<Tile>> _tiles;
        public List<List<Tile>> Tiles
        {
            get { return _tiles; }
            set
            {
                _tiles = value;
                RaisePropertyChanged();
            }
        }
    }
}
