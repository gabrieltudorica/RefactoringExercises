﻿using System.Configuration;
using System.Diagnostics;

namespace TicTacToe.Game
{
    public class Logic
    {
        private int movesLeft;
        private readonly Board board;
        private readonly Turn turn;

        public Logic(Board board)
        {
            movesLeft = int.Parse(ConfigurationManager.AppSettings["MaxMoves"]);
            this.board = board;
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

        public string GetCurrentTurn()
        {
            return turn.GetCurrent();
        }

        public string GetNextTurn()
        {
            return turn.GetNext();
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
            bool isWin = false;

            foreach (string[] cells in board.GetRows())
            {
                isWin |= CellsMatch(cells);
            }          

            return isWin;
        }

        private bool IsVerticalWin()
        {
            bool isWin = false;
            
            foreach (string[] cells in board.GetColumns())
            {
                isWin |= CellsMatch(cells);
            }

            return isWin;
        }

        private bool IsDiagonalWin()
        {
            bool isWin = false;

            foreach (string[] cells in board.GetDiagonals())
            {
                isWin |= CellsMatch(cells);
            }

            return isWin;
        }

        private static bool CellsMatch(string[] cells)
        {
            if (cells[0] == string.Empty)
            {
                return false;
            }

            return cells[0] == cells[1] && cells[1] == cells[2];
        }
    }
}