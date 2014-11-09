namespace Tic_Tac_Toe
{
    public class Turn
    {
        private const string NoughtSymbol = "O";
        private const string CrossSymbol = "X";

        private TurnType current;
        private int maxTurns = 9;

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
            maxTurns--;

            if (current == TurnType.Cross)
            {
                current = TurnType.Nought;
                return;
            }

            current = TurnType.Cross;
        }

        public int GetRemainingTurns()
        {
            return maxTurns;
        }

    }
}
