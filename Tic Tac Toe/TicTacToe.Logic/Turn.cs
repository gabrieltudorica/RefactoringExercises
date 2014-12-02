namespace TicTacToe.Game
{
    public class Turn
    {        
        private SymbolTypes current;

        public Turn()
        {
            current = SymbolTypes.Cross;
        }
        
        public SymbolTypes GetCurrent()
        {
            return current;
        }     

        public void Advance()
        {
            if (current == SymbolTypes.Cross)
            {
                current = SymbolTypes.Nought;
                return;
            }

            current = SymbolTypes.Cross;
        }
    }    
}
