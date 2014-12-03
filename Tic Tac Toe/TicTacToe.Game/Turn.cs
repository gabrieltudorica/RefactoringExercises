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
