using TicTacToe.Game;

namespace TicTacToe.MVP
{
    public class Presenter
    {
        private readonly IView view;

        private readonly Board board;
        private readonly Statistics statistics;
        private ViewModel viewModel;

        public Presenter(IView view)
        {
            this.view = view;

            board = new Board();            
            statistics = new Statistics();
            viewModel = new ViewModel();
        }

        public void Initialize()
        {
            UpdateView();
        }

        public void NewGame()
        {
            board.NewGame();
            viewModel = new ViewModel();
            UpdateView();
        }

        public void MarkMove(int cellIndex)
        {
            board.MarkMove(cellIndex);
            UpdateView();
            board.AdvanceTurn();            
        }

        private void UpdateView()
        {
            ViewModel viewModel = GetViewModel();
            view.Update(viewModel);
        }

        private ViewModel GetViewModel()
        {
            bool isGameOver = board.IsDraw() || board.IsWin();

            if (isGameOver)
            {
                UpdateStatistics();
                viewModel.EndGameMessage = GetEndMessage();
            }
            
            viewModel.IsGameOver = isGameOver;
            viewModel.Cells = board.GetCells();
            viewModel.Statistics = statistics;

            return viewModel;
        }

        private void UpdateStatistics()
        {
            if (board.IsDraw())
            {
                statistics.IncrementDrawsCount();
                return;
            }

            if (board.GetWinner() == SymbolType.Cross)
            {
                statistics.IncrementCrossesWins();
                return;
            }

            statistics.IncrementNoughtsWins();
        }

        private string GetEndMessage()
        {
            if (board.IsDraw())
            {
                return "Match ended in draw!";
            }

            return new SymbolTypeConverter().GetString(board.GetCurrentTurn()) + " wins!";
        }
    }
}
