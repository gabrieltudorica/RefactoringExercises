using System.Diagnostics;

namespace TicTacToe.Game
{
    public class Cell
    {
        private SymbolType type;

        public Cell()
        {
            type = SymbolType.Uninitialized;
        }

        public bool IsUsed()
        {
            return type != SymbolType.Uninitialized;
        }

        public SymbolType GetSymbolType()
        {
            return type;
        }

        public void SetSymbolType(SymbolType type)
        {
            Trace.Assert(IsUsed() == false, "SetSymbolType should be set one time only");

            this.type = type;
        }        
    }
}