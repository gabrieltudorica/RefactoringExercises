namespace TicTacToe
{
    public class Turn
    {
        private const string NoughtSymbol = "O";
        private const string CrossSymbol = "X";

        private TurnType current;

        public Turn()
        {
            current = TurnType.Cross;
        }
        
        public TurnType GetCurrent()
        {
            return current;
        }

        public string GetCurrentSymbol()
        {
            return current == TurnType.Cross ? CrossSymbol : NoughtSymbol;
        }

        public void Change()
        {
            if (current == TurnType.Cross)
            {
                current = TurnType.Nought;
                return;
            }

            current = TurnType.Cross;
        }
    }
}
