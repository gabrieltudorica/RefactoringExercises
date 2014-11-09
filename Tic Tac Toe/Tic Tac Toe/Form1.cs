﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        private int xWins;
        private int yWins;
        private int d;
        private List<Button> buttons = new List<Button>();

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
            for (int i = 0; i < 9; i++)
                CreateCell();
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
            flowLayoutPanel1.Controls.Add(button);
        }

        private void ClearBoard()
        {
            for (int i = 0; i < 9; i++)            
                ClearCell(i);            

            turn = new Turn();
        }

        private void ClearCell(int i)
        {
            buttons[i].Enabled = true;
            buttons[i].Text = "";
        }
        private Turn turn = new Turn();

        private void OnButton_Click(object sender, EventArgs e)
        {           
            Button button = (Button)sender;
            button.Text = turn.GetCurrentSymbol();
            
            turn.Change();
            nextTurn.Text = turn.GetCurrentSymbol();

            button.Enabled = false;

            check();
            if (turn.GetRemainingTurns() == 0)
            {
                MessageBox.Show("Game Draw");
                d++;
                label6.Text = d.ToString();
                ClearBoard();
            }
        }

        void check() // Here is the check() function in which conditions will full fill.
        {
            //FOr Rows
            if (buttons[0].Text == buttons[1].Text && buttons[1].Text == buttons[2].Text && buttons[0].Text != "")
            {
                MessageBox.Show(buttons[0].Text + " Wins");
                if (buttons[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }

                ClearBoard();
            }
            if (buttons[3].Text == buttons[4].Text && buttons[4].Text == buttons[5].Text && buttons[3].Text != "")
            {
                MessageBox.Show(buttons[3].Text + " Wins");
                if (buttons[3].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }
            if (buttons[6].Text == buttons[7].Text && buttons[7].Text == buttons[8].Text && buttons[6].Text != "")
            {
                MessageBox.Show(buttons[6].Text + " Wins");
                if (buttons[6].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }

            //For Coloums
            if (buttons[0].Text == buttons[3].Text && buttons[3].Text == buttons[6].Text && buttons[0].Text != "")
            {
                MessageBox.Show(buttons[0].Text + " Wins");
                if (buttons[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }
            if (buttons[1].Text == buttons[4].Text && buttons[4].Text == buttons[7].Text && buttons[1].Text != "")
            {
                MessageBox.Show(buttons[1].Text + " Wins");
                if (buttons[1].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }
            if (buttons[2].Text == buttons[5].Text && buttons[5].Text == buttons[8].Text && buttons[2].Text != "")
            {
                MessageBox.Show(buttons[2].Text + " Wins");
                if (buttons[2].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }

            //For Diagnols
            if (buttons[0].Text == buttons[4].Text && buttons[4].Text == buttons[8].Text && buttons[0].Text != "")
            {
                MessageBox.Show(buttons[0].Text + " Wins");
                if (buttons[0].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }
            if (buttons[2].Text == buttons[4].Text && buttons[4].Text == buttons[6].Text && buttons[2].Text != "")
            {
                MessageBox.Show(buttons[2].Text + " Wins");
                if (buttons[2].Text == "X")
                {
                    xWins++;
                    label3.Text = xWins.ToString();
                }
                else
                {
                    yWins++;
                    label4.Text = yWins.ToString();
                }
                ClearBoard();
            }
        }



    }

}
