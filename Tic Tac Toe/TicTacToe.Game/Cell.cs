using System.Diagnostics;

namespace TicTacToe.Game
{
    public class Cell
    {
        private bool isUsed;
        private SymbolType type;

        public Cell()
        {
            type = SymbolType.Uninitialized;
        }

        public bool IsUsed()
        {
            return isUsed;
        }

        public SymbolType GetSymbolType()
        {
            return type;
        }

        public void SetSymbolType(SymbolType type)
        {
            Trace.Assert(isUsed == false, "SetSymbolType should be set one time only");

            this.type = type;
            isUsed = true;
        }        
    }
}