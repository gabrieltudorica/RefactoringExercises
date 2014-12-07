using TicTacToe.Game;

namespace TicTacToe.MVP
{
    public class Presenter
    {
        private readonly IView view;

        private Board board;
        private Logic logic;
        private readonly Statistics statistics;
        private ViewModel viewModel;

        public Presenter(IView view)
        {
            this.view = view;

            board = new Board();    
            logic = new Logic(board);
            statistics = new Statistics();
            viewModel = new ViewModel();
        }

        public void Initialize()
        {
            UpdateView();
        }

        public void NewGame()
        {
            board = new Board();
            logic = new Logic(board);
            viewModel = new ViewModel();
            UpdateView();
        }

        public void MarkMove(int cellIndex)
        {
            board.MarkMove(cellIndex, logic.GetCurrentTurn());
            UpdateView();
            logic.AdvanceTurn();            
        }

        private void UpdateView()
        {
            ViewModel viewModel = GetViewModel();
            view.Update(viewModel);
        }

        private ViewModel GetViewModel()
        {
            bool isGameOver = logic.IsDraw() || logic.IsWin();

            if (isGameOver)
            {
                UpdateStatistics();
                viewModel.EndGameMessage = GetEndMessage();
            }
            
            viewModel.IsGameOver = isGameOver;
            viewModel.Cells = board.GetCells();
            viewModel.Statistics = statistics;
            viewModel.NextTurn = logic.GetNextTurn();

            return viewModel;
        }

        private void UpdateStatistics()
        {
            if (logic.IsDraw())
            {
                statistics.IncrementDrawsCount();
                return;
            }

            string winner = logic.GetCurrentTurn();
            if (winner == Config.CrossSymbol)
            {
                statistics.IncrementCrossesWins();
                return;
            }

            statistics.IncrementNoughtsWins();
        }

        private string GetEndMessage()
        {
            if (logic.IsDraw())
            {
                return "Match ended in draw!";
            }

            return logic.GetCurrentTurn() + " wins!";
        }
    }
}
