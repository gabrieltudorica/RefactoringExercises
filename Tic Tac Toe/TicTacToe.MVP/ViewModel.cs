using TicTacToe.Game;

namespace TicTacToe.MVP
{
    public class ViewModel
    {
        public Cell[] Cells { get; set; }        
        public Statistics Statistics { get; set; }
        public bool IsDraw { get; set; }
        public bool IsWin { get; set; }
        public SymbolTypes Winner { get; set; }
    }
}
