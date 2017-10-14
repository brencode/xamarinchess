using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinChess.Model
{
    public class Tile : ModelObject
    {
        public event EventHandler TileTappedEvent;

		public int X { get; set; }
		public int Y { get; set; }

		private Piece _piece;
		public Piece Piece
		{
			get { return _piece; }
			set
			{
				_piece = value;
				RaisePropertyChanged();
			}
		}

        private bool _isHighlighted;
        public bool IsHighlighted
        {
            get
            {
                return _isHighlighted;
            }
            set
            {
                _isHighlighted = value;
                RaisePropertyChanged();
            }
        } 

        public ICommand TileTapped
        {
            get
            {
                return new Command(() =>
                {
                    TileTappedEvent?.Invoke(this, null);
                });
            }
        }
    }
}
