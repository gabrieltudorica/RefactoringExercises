using System.Configuration;
using System.Diagnostics;

namespace TicTacToe.Game
{
    public class Logic
    {
        private int movesLeft;
        private readonly Cell[] cells;
        private readonly Turn turn;

        public Logic(Cell[] cells)
        {
            movesLeft = int.Parse(ConfigurationManager.AppSettings["MaxMoves"]);
            this.cells = cells;
            turn = new Turn();
        }

        public void AdvanceTurn()
        {
            if(IsWin() || IsDraw())
            {
                return;
            }

            movesLeft--;
            Trace.Assert(movesLeft >= 0, "Number of moves left should not drop below zero.");
            
            turn.Advance();
        }

        public SymbolTypes GetCurrentTurn()
        {
            return turn.GetCurrent();
        }

        public bool IsDraw()
        {
            return movesLeft == 0;
        }

        public bool IsWin()
        {
            return IsHorizontalWin() || IsVerticalWin() || IsDiagonalWin();
        }

        private bool IsHorizontalWin()
        {
            bool win = MarkedCellsMatch(cells[0], cells[1], cells[2]);
            win |= MarkedCellsMatch(cells[3], cells[4], cells[5]);
            win |= MarkedCellsMatch(cells[6], cells[7], cells[8]);

            return win;
        }

        private bool IsVerticalWin()
        {
            bool win = MarkedCellsMatch(cells[0], cells[3], cells[6]);
            win |= MarkedCellsMatch(cells[1], cells[4], cells[7]);
            win |= MarkedCellsMatch(cells[2], cells[5], cells[8]);

            return win;
        }

        private bool IsDiagonalWin()
        {
            bool win = MarkedCellsMatch(cells[0], cells[4], cells[8]);
            win |= MarkedCellsMatch(cells[2], cells[4], cells[6]);

            return win;
        }

        private static bool MarkedCellsMatch(Cell cell1, Cell cell2, Cell cell3)
        {
            if (cell1.GetSymbolType() == SymbolTypes.Uninitialized)
            {
                return false;
            }

            return cell1.GetSymbolType() == cell2.GetSymbolType() && cell2.GetSymbolType() == cell3.GetSymbolType();
        }
    }
}