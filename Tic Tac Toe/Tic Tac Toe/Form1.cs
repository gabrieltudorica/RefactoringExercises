using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int xWins;
        private int yWins;
        private int draws;
        private List<Button> buttons = new List<Button>();
        private Logic logic;
        private Turn turn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateBoard();
        }

        private void CreateBoard()
        {
            StartGame();

            for (int i = 0; i < 9; i++)
            {
                CreateCell();
            }            
        }

        private void StartGame()
        {
            logic = new Logic(buttons);
            turn = new Turn();
        }

        private void CreateCell()
        {
            Button button = CreateButton();
            buttons.Add(button);
            AddButtonToBoard(button);
        }        

        private Button CreateButton()
        {
            var button = new Button {Width = 100, Height = 100};
            button.Click += OnButton_Click;

            return button;
        }

        private void AddButtonToBoard(Button button)
        {
            board.Controls.Add(button);
        }

        private void ClearBoard()
        {
            for (int i = 0; i < 9; i++)            
                ClearCell(i);            

            StartGame();
        }

        private void ClearCell(int i)
        {
            buttons[i].Enabled = true;
            buttons[i].Text = "";
        }
        private void OnButton_Click(object sender, EventArgs e)
        {           
            Button button = (Button)sender;
            button.Text = turn.GetCurrentSymbol();
            
            turn.Change();
            
            nextTurn.Text = turn.GetCurrentSymbol();

            button.Enabled = false;

            if (IsGameFinished())
            {
                ClearBoard();
            }
        }

        private bool IsGameFinished()
        {
            logic.UpdateNumberOfMoves();

            if (!logic.IsGameOver())
            {                
                return false;
            }

            if (logic.IsDraw())
            {
                MessageBox.Show("Game Draw");
                draws++;
                drawsCount.Text = draws.ToString();

                return true;
            }

            string winner = logic.GetWinner();
            MessageBox.Show(winner + " Wins");

            if (winner == "X")
            {
                xWins++;
                label3.Text = xWins.ToString();
            }
            else
            {
                yWins++;
                label4.Text = yWins.ToString();
            }         

            return true;
        }
    }
}
