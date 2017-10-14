using System;
using System.Collections.Generic;
using XamarinChess.Model;

namespace XamarinChess.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Initialize the board, and the pieces on that board.
            Board = new ChessBoard(new List<List<Tile>>());
            // Create the player
            player = new GamePlayer(PlayerType.Ai);
            // Create the Ai player
            ai = new GamePlayer(PlayerType.Player);

            // Initialie the player's pieces
            player.Pieces = new List<Piece>();

            // Initialize the ai's pieces   
            ai.Pieces = new List<Piece>();

            // Setup the tiles
            for (int i = 0; i < 2; i++)
            {
                this.Board.Tiles.Add(new List<Tile>());
                for (int j = 0; j < 2; j++)
                {
                    Tile tile = new Tile();
                    tile.X = i;
                    tile.Y = j;
                    tile.TileTappedEvent += TileTapped;
                    Board.Tiles[i].Add(tile);
                }
            }

            // TODO: dynamically add chess pieces

            // Setup the player's pieces, add the pawns
            player.Pieces.Add(new Piece(new XYCoordinate(0, 0), PieceType.Pawn, PlayerType.Player, PieceColor.White));
            player.Pieces.Add(new Piece(new XYCoordinate(1, 0), PieceType.Pawn, PlayerType.Player, PieceColor.White));

            // Setup the ai's pieces, add the pawns
            ai.Pieces.Add(new Piece(new XYCoordinate(0, 1), PieceType.Pawn, PlayerType.Ai, PieceColor.Black));
            ai.Pieces.Add(new Piece(new XYCoordinate(1, 1), PieceType.Pawn, PlayerType.Ai, PieceColor.Black));

            // Setup the AI's pieces    
            //ai.Pieces.Add(new Piece(new XYCoordinate()))     
            DrawBoard();
        }

        private Tile _selectedTile;

        private void TileTapped(object sender, EventArgs e)
        {
            Tile tile = sender as Tile;

            if (_selectedTile != null)
            {
                _selectedTile.IsHighlighted = false;
                TryToMovePlayerPiece();
                _selectedTile = null;
            }
            else
            {
                tile.IsHighlighted = true;
                _selectedTile = tile;
            }
        }

        private void TryToMovePlayerPiece()
        {
            
        }

        /// <summary>
        /// Set the piece of every tile on the board to the piece 
        /// that could be on that tile.
        /// </summary>
        public void DrawBoard()
        {
            // Empty out all the tiles on the board
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    // Use a default piece on each tile
                    Board.Tiles[i][j].Piece = default(Piece);
                    Board.Tiles[i][j].IsHighlighted = false;
                }
            }

            // TODO: don't repeat this logic, put inside a helper method

            // Setup the player's pieces on the ChessBoard's tiles
            foreach (Piece piece in player.Pieces)
            {
                // Get a reference to the tile the piece is on
                Tile tile = Board.Tiles[piece.X][piece.Y];
                // Set the tile's piece
                tile.Piece = piece;

            }

            // Setup the AI's pieces
            foreach (Piece piece in ai.Pieces)
            {
				// Get a reference to the tile the piece is on
				Tile tile = Board.Tiles[piece.X][piece.Y];
				// Set the tile's piece
				tile.Piece = piece;
            }
        }

        // Check to see if the space has been filled. Adding pieces only occurs at initialization.
        //public void AddPiece(PieceType pieceType, PlayerType targetPlayer, XYCoordinate coordinate)
        //{
        //    switch(pieceType)
        //    {
        //        case PieceType.Pawn:
        //            if (targetPlayer == PlayerType.PlayerType.Player)
        //                this.player.Pieces.Add(new Piece())
        //            break;
        //        default:
        //            break;
        //    }
        //}

        // The player
        private GamePlayer player;
        // The ai
        private GamePlayer ai;

        private ChessBoard _board;

        public ChessBoard Board
        {
            get { return _board; }
            set 
            {
                _board = value;
                RaisePropertyChanged();
            }
        }
    }
}
