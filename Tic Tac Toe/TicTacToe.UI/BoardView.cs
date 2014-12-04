using System;
using System.Configuration;
using System.Windows.Forms;
using TicTacToe.Game;
using TicTacToe.MVP;

namespace TicTacToe.UI
{
    public partial class BoardView : Form, IView
    {
        private readonly Presenter presenter;

        public BoardView()
        {
            InitializeComponent();
            CreateButtons();
            
            presenter = new Presenter(this);
            presenter.Initialize();                       
        }

        private void CreateButtons()
        {
            for (int i = 0; i < int.Parse(ConfigurationManager.AppSettings["CellCount"]); i++)
            {
                AddButtonToBoard(CreateButton(i));
            }
        }

        private Button CreateButton(int buttonIndex)
        {
            int buttonSize = int.Parse(ConfigurationManager.AppSettings["ButtonSizeInPixels"]);

            var button = new Button
            {
                Width = buttonSize,
                Height = buttonSize, 
                Name = buttonIndex.ToString()
            };

            button.Click += OnButton_Click;

            return button;
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            presenter.MarkMove(int.Parse(button.Name));
        }

        private void AddButtonToBoard(Button button)
        {
            board.Controls.Add(button);
        }

        public void Update(ViewModel viewModel)
        {
            UpdateButtons(viewModel.Cells);
            UpdateStatistics(viewModel.Statistics);

            if (!viewModel.IsGameOver)
            {
                return;
            }

            MessageBox.Show(viewModel.EndGameMessage);
            NewGame();
        }

        private void UpdateButtons(Cell[] cells)
        {
            for (int i = 0; i < cells.Length; i++)
            {
                UpdateButton(i, cells[i]);
            }
        }        

        private void UpdateButton(int index, Cell cell)
        {
            if (!cell.IsUsed())
            {
                return;
            }            

            var button = (Button)board.Controls.Find(index.ToString(), false)[0];
            button.Text = new SymbolTypeConverter().GetString(cell.GetSymbolType());
            button.Enabled = false;
        }

        private void UpdateStatistics(Statistics stats)
        {
            xWinsCount.Text = "z";
            yWinsCount.Text = "z";
            drawsCount.Text = "Z";
        }       

        private void NewGame()
        {
            ClearBoard();
            presenter.NewGame();            
        }

        private void ClearBoard()
        {
            foreach (Button button in board.Controls)
            {
                ClearCell(button);   
            }                
        }

        private static void ClearCell(Button button)
        {
            button.Enabled = true;
            button.Text = "";
        }
    }
}
