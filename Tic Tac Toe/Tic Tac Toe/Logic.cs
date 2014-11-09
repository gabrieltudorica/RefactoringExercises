using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public class Logic
    {
        private readonly List<Button> cells;
        private int maxMoves = 9;
        private string winner;

        public Logic(List<Button> cells)
        {
            this.cells = cells;
        }

        public bool IsGameOver()
        {
            if (maxMoves == 0)
            {
                return true;
            }

            bool winnerFound = IsHorizontalWin();
            winnerFound |= IsVerticalWin();
            winnerFound |= IsDiagonalWin();

            return winnerFound;
        }

        private bool IsHorizontalWin()
        {
            bool win = IsWinner(cells[0], cells[1], cells[2]);
            win |= IsWinner(cells[3], cells[4], cells[5]);
            win |= IsWinner(cells[6], cells[7], cells[8]);

            return win;
        }

        private bool IsVerticalWin()
        {
            bool win = IsWinner(cells[0], cells[3], cells[6]);
            win |= IsWinner(cells[1], cells[4], cells[7]);
            win |= IsWinner(cells[2], cells[5], cells[8]);

            return win;
        }

        private bool IsDiagonalWin()
        {
            bool win = IsWinner(cells[0], cells[4], cells[8]);
            win |= IsWinner(cells[2], cells[4], cells[6]);

            return win;
        }

        private bool IsWinner(Button cell1, Button cell2, Button cell3)
        {
            if (string.IsNullOrEmpty(cell1.Text))
            {
                return false;
            }

            if (cell1.Text != cell2.Text || cell2.Text != cell3.Text)
            {
                return false;
            }

            winner = cell1.Text;            
            return true;
        }

        public void UpdateNumberOfMoves()
        {
            maxMoves--;
        }

        public string GetWinner()
        {
            return winner;
        }

        public bool IsDraw()
        {
            Debug.Assert(maxMoves >= 0, "MaxMoves should stop at 0");
            return maxMoves == 0;
        }
    }
}
