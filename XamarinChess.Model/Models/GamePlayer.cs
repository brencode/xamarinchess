using System;
using System.Collections.Generic;

namespace XamarinChess.Model
{
    public class GamePlayer : ModelObject
    {
        public GamePlayer(PlayerType player)
        {
            PlayerType = player;
        }

        public PlayerType PlayerType { get; }
        public List<Piece> Pieces { get; set; }
    }
}
