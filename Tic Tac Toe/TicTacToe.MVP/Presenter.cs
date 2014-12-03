using TicTacToe.Game;

namespace TicTacToe.MVP
{
    public class Presenter
    {
        private readonly IView view;
        private readonly Board board;
        private ViewModel viewModel;
        private readonly Statistics statistics;

        public Presenter(IView view)
        {
            this.view = view;
            board = new Board();
            viewModel = new ViewModel();
            statistics = new Statistics();
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
            board.AdvanceTurn();
            UpdateView();
        }

        private void UpdateView()
        {
            ViewModel viewModel = GetViewModel();
            view.Update(viewModel);
        }

        private ViewModel GetViewModel()
        {
            bool isGameOver = board.IsDraw() || board.IsWin();
            
            viewModel.Cells = board.GetCells();
            viewModel.Statistics = statistics;
            viewModel.IsGameOver = isGameOver;
            
            if (isGameOver)
            {
                viewModel.EndGameMessage = GetEndMessage();
            }

            return viewModel;
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
