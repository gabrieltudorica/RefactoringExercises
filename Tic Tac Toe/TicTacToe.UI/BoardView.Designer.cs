namespace TicTacToe.UI
{
    partial class BoardView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardView));
            this.board = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crossesWinsCount = new System.Windows.Forms.Label();
            this.noughtsWinsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawsCount = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nextTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Gray;
            this.board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("board.BackgroundImage")));
            this.board.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.board.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.board.ForeColor = System.Drawing.Color.Yellow;
            this.board.Location = new System.Drawing.Point(60, 130);
            this.board.Margin = new System.Windows.Forms.Padding(4);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(400, 400);
            this.board.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "X Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "O Wins:";
            // 
            // crossesWinsCount
            // 
            this.crossesWinsCount.AutoSize = true;
            this.crossesWinsCount.BackColor = System.Drawing.Color.Gray;
            this.crossesWinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossesWinsCount.Location = new System.Drawing.Point(171, 11);
            this.crossesWinsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crossesWinsCount.Name = "crossesWinsCount";
            this.crossesWinsCount.Size = new System.Drawing.Size(0, 25);
            this.crossesWinsCount.TabIndex = 3;
            // 
            // noughtsWinsCount
            // 
            this.noughtsWinsCount.AutoSize = true;
            this.noughtsWinsCount.BackColor = System.Drawing.Color.Gray;
            this.noughtsWinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noughtsWinsCount.Location = new System.Drawing.Point(171, 44);
            this.noughtsWinsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.noughtsWinsCount.Name = "noughtsWinsCount";
            this.noughtsWinsCount.Size = new System.Drawing.Size(0, 25);
            this.noughtsWinsCount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Draws:";
            // 
            // drawsCount
            // 
            this.drawsCount.AutoSize = true;
            this.drawsCount.BackColor = System.Drawing.Color.Gray;
            this.drawsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsCount.Location = new System.Drawing.Point(171, 76);
            this.drawsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawsCount.Name = "drawsCount";
            this.drawsCount.Size = new System.Drawing.Size(0, 25);
            this.drawsCount.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 45);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Turn:";
            // 
            // nextTurn
            // 
            this.nextTurn.AutoSize = true;
            this.nextTurn.BackColor = System.Drawing.Color.Gray;
            this.nextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTurn.Location = new System.Drawing.Point(346, 45);
            this.nextTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextTurn.Name = "nextTurn";
            this.nextTurn.Size = new System.Drawing.Size(0, 25);
            this.nextTurn.TabIndex = 9;
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(447, 499);
            this.Controls.Add(this.drawsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nextTurn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.noughtsWinsCount);
            this.Controls.Add(this.crossesWinsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BoardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label crossesWinsCount;
        private System.Windows.Forms.Label noughtsWinsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label drawsCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nextTurn;
    }
}

