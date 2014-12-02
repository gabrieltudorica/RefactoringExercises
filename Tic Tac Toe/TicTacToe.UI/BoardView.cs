using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using TicTacToe.Game;
using TicTacToe.MVP;

namespace TicTacToe.UI
{
    public partial class BoardView : Form, IView
    {
        private readonly Presenter presenter;
        private readonly Dictionary<SymbolTypes, string> stringSymbols;
        public BoardView()
        {
            InitializeComponent();
            CreateButtons();
            stringSymbols = new Dictionary<SymbolTypes, string>
                                {
                                    {SymbolTypes.Cross, "X"},
                                    {SymbolTypes.Nought, "O"}
                                };

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
            var button = new Button { Width = 100, Height = 100 };
            button.Name = buttonIndex.ToString();
            button.Click += OnButton_Click;

            return button;
        }

        private void AddButtonToBoard(Button button)
        {
            board.Controls.Add(button);
        }

        public void Update(ViewModel viewModel)
        {
            for (int i = 0; i < viewModel.Cells.Length; i++)
            {
                UpdateButton(i, viewModel.Cells[i]);
            }

            if(viewModel.IsDraw)
            {
                MessageBox.Show("Match ended in draw");
                NewGame();
            }

            if(viewModel.IsWin)
            {
                MessageBox.Show(stringSymbols[viewModel.Winner] + " wins!");
                NewGame();
            }

            //statistics
            xWinsCount.Text = "z";
            yWinsCount.Text = "z";
            drawsCount.Text = "Z";
        }

        private void UpdateButton(int index, Cell cell)
        {               
            if (!cell.IsUsed())
            {
                return;
            }            

            var button = (Button)board.Controls.Find(index.ToString(), false)[0];
            button.Text = stringSymbols[cell.GetSymbolType()];
        }        

        private void OnButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            presenter.MarkMove(int.Parse(button.Name));
            button.Enabled = false;
        }

        private void NewGame()
        {
            presenter.NewGame();
            ClearBoard();
        }

        private void ClearBoard()
        {
            foreach (Button button in board.Controls)
            {
                ClearCell(button);   
            }                
        }

        private void ClearCell(Button button)
        {
            button.Enabled = true;
            button.Text = "";
        }
    }
}
