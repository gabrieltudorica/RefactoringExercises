using TicTacToe.Game;

namespace TicTacToe.MVP
{
    public class ViewModel
    {
        public Cell[] Cells { get; set; }        
        public Statistics Statistics { get; set; }
        public bool IsGameOver { get; set; }
        public string EndGameMessage { get; set; }
        public SymbolType NextTurn { get; set; }
    }
}
