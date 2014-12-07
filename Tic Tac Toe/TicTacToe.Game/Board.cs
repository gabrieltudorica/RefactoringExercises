using System.Collections.Generic;

namespace TicTacToe.Game
{
    public class Board
    {
        private readonly string[] cells;

        public Board()
        {
            cells = CreateCells();
        }

        private static string[] CreateCells()
        {
            var cells = new List<string>();

            for (int i = 0; i < Config.CellCount; i++)
            {
                cells.Add(string.Empty);
            }

            return cells.ToArray();
        }              

        public IEnumerable<string> GetCells()
        {
            return cells;
        }

        public IEnumerable<string[]> GetRows()
        {
            var rowOne = new[] { cells[0], cells[1], cells[2]};
            var rowTwo = new[] { cells[3], cells[4], cells[5] };
            var rowThree = new[] { cells[6], cells[7], cells[8] };

            return new List<string[]> {rowOne, rowTwo, rowThree};
        }

        public IEnumerable<string[]> GetColumns()
        {
            var columnOne = new[] { cells[0], cells[3], cells[6] };
            var columnTwo = new[] { cells[1], cells[4], cells[7] };
            var columnThree = new[] { cells[2], cells[5], cells[8] };

            return new List<string[]> { columnOne, columnTwo, columnThree };
        }

        public IEnumerable<string[]> GetDiagonals()
        {
            var diagonalOne = new[] { cells[0], cells[4], cells[8] };
            var diagonalTwo = new[] { cells[2], cells[4], cells[6] };

            return new List<string[]> { diagonalOne, diagonalTwo };
        }

        public void MarkMove(int cellIndex, string symbol)
        {
            cells[cellIndex] = symbol;
        }
    }   
}
