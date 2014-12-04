namespace TicTacToe.Game
{
    public class Turn
    {        
        private SymbolType current;

        public Turn()
        {
            current = SymbolType.Cross;
        }
        
        public SymbolType GetCurrent()
        {
            return current;
        }     

        public SymbolType GetNext()
        {
            if (current == SymbolType.Cross)
            {
                return SymbolType.Nought;
            }

            return SymbolType.Cross;
        }

        public void Advance()
        {
            if (current == SymbolType.Cross)
            {
                current = SymbolType.Nought;
                return;
            }

            current = SymbolType.Cross;
        }
    }    
}
