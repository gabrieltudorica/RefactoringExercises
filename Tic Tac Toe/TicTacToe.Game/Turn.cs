namespace TicTacToe.Game
{
    public class Turn
    {        
        private string current;

        public Turn()
        {
            current = Configuration.CrossSymbol;
        }
        
        public string GetCurrent()
        {
            return current;
        }     

        public string GetNext()
        {
            return current == Configuration.CrossSymbol ? Configuration.NoughtSymbol : Configuration.CrossSymbol;
        }

        public void Advance()
        {
            if (current == Configuration.CrossSymbol)
            {
                current = Configuration.NoughtSymbol;
                return;
            }

            current = Configuration.CrossSymbol;
        }
    }    
}
