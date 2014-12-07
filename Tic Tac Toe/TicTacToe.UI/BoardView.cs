using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
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
                Name = buttonIndex.ToString(CultureInfo.InvariantCulture)
            };

            button.Click += OnButton_Click;

            return button;
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
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
            nextTurn.Text = viewModel.NextTurn;

            if (!viewModel.IsGameOver)
            {
                return;
            }

            MessageBox.Show(viewModel.EndGameMessage);
            NewGame();
        }

        private void UpdateButtons(IEnumerable<string> cells)
        {
            int index = 0;
            foreach (string cell in cells)
            {
                UpdateButton(index, cell);
                index++;
            }
        }        

        private void UpdateButton(int index, string cell)
        {
            if (cell == string.Empty)
            {
                return;
            }

            var button = (Button)board.Controls.Find(index.ToString(CultureInfo.InvariantCulture), false)[0];
            button.Text = cell;
            button.Enabled = false;
        }

        private void UpdateStatistics(Statistics stats)
        {
            crossesWinsCount.Text = stats.GetCrossesWinsCount().ToString(CultureInfo.InvariantCulture);
            noughtsWinsCount.Text = stats.GetNoughtsWinsCount().ToString(CultureInfo.InvariantCulture);
            drawsCount.Text = stats.GetDrawsCount().ToString(CultureInfo.InvariantCulture);
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
