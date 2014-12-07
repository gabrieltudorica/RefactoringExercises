namespace TicTacToe.Game
{
    public class Turn
    {        
        private string current;

        public Turn()
        {
            current = Config.CrossSymbol;
        }
        
        public string GetCurrent()
        {
            return current;
        }     

        public string GetNext()
        {
            return current == Config.CrossSymbol ? Config.NoughtSymbol : Config.CrossSymbol;
        }

        public void Advance()
        {
            if (current == Config.CrossSymbol)
            {
                current = Config.NoughtSymbol;
                return;
            }

            current = Config.CrossSymbol;
        }
    }    
}
