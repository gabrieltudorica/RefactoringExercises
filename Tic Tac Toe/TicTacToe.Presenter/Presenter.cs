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
            if (board.IsDraw())
            {
                viewModel.IsDraw = true;
                viewModel.IsWin = false;
            }

            if (board.IsWin())
            {
                viewModel.IsDraw = false;
                viewModel.IsWin = true;
                viewModel.Winner = board.GetCurrentTurn();
            }

            viewModel.Cells = board.GetCells();
            viewModel.Statistics = statistics;

            return viewModel;
        }

        
    }
}
