namespace TicTacToe.Game
{
    public class Statistics
    {
        private int noughtsWins;
        private int crossesWins;
        private int drawsCount;

        public void IncrementNoughtsWins()
        {
            noughtsWins++;
        }

        public void IncrementCrossesWins()
        {
            crossesWins++;
        }

        public void IncrementDrawsCount()
        {
            drawsCount++;
        }

        public int GetNoughtsWinsCount()
        {
            return noughtsWins;
        }

        public int GetCrossesWinsCount()
        {
            return crossesWins;
        }

        public int GetDrawsCount()
        {
            return drawsCount;
        }
    }
}
