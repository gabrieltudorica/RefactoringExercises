using System.Diagnostics;

namespace TicTacToe.Game
{
    public class Cell
    {
        private bool isUsed;
        private SymbolTypes type;

        public Cell()
        {
            type = SymbolTypes.Uninitialized;
        }

        public bool IsUsed()
        {
            return isUsed;
        }

        public SymbolTypes GetSymbolType()
        {
            return type;
        }

        public void SetSymbolType(SymbolTypes type)
        {
            Trace.Assert(isUsed == false, "SetSymbolType should be set one time only");

            this.type = type;
            isUsed = true;
        }        
    }
}