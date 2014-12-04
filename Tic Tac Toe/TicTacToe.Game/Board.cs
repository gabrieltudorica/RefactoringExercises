using System.Collections.Generic;
using System.Configuration;

namespace TicTacToe.Game
{
    public class Board
    {
        private readonly int cellCount = int.Parse(ConfigurationManager.AppSettings["CellCount"]);
        
        private Cell[] cells;
        private Logic logic;        

        public Board()
        {
            NewGame();
        }

        public void NewGame()
        {
            cells = CreateCells();
            logic = new Logic(cells);
        }

        private Cell[] CreateCells()
        {
            var cells = new List<Cell>();

            for (int i = 0; i < cellCount; i++)
            {
                var cell = new Cell();
                cells.Add(cell);
            }

            return cells.ToArray();
        }              

        public Cell[] GetCells()
        {
            return cells;
        }

        public SymbolType GetCurrentTurn()
        {
            return logic.GetCurrentTurn();
        }

        public SymbolType GetNextTurn()
        {
            return logic.GetNextTurn();
        }

        public void MarkMove(int cellIndex)
        {
            cells[cellIndex].SetSymbolType(GetCurrentTurn());
        }

        public void AdvanceTurn()
        {
            logic.AdvanceTurn();
        }

        public bool IsWin()
        {
            return logic.IsWin();
        }

        public SymbolType GetWinner()
        {
            return logic.GetCurrentTurn();
        }

        public bool IsDraw()
        {
            return logic.IsDraw();
        }        
    }   
}
