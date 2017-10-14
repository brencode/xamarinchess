using System;
using XamarinChess.Model;

namespace XamarinChess.Model
{
    /// <summary>
    /// A piece on the gameboard. (Used a struct to optimize for quick arithmetic, 
    /// the AI needs to process things very quickly.
    /// </summary>
    public struct Piece 
    {
        public Piece(XYCoordinate coordinate, PieceType pieceType, PlayerType player, PieceColor color)
        {
            X = coordinate.X;
            Y = coordinate.Y;
            PieceType = pieceType;
            Owner = player;
            Color = color;
        }

        /// <summary>
        /// Gets or sets the x coordinate.
        /// </summary>
        /// <value>The x.</value>
        public int X { get; set; }
        /// <summary>
        /// Gets or sets the y coordiante of the piece.
        /// </summary>
        /// <value>The y.</value>
        public int Y { get; set; }

        public PieceType PieceType { get; }

        public PlayerType Owner { get; }

        public PieceColor Color { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:XamarinChess.Models.Piece"/> is the AI's piece.
        /// </summary>
        /// <value><c>true</c> if is ai; otherwise, <c>false</c>.</value>
        public bool IsAi => Owner == PlayerType.Ai;

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:XamarinChess.Models.Piece"/> is the player's piece.
        /// </summary>
        /// <value><c>true</c> if is player; otherwise, <c>false</c>.</value>
        public bool IsPlayer => Owner == PlayerType.Player;
    }
}
