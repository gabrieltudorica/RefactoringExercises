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
            this.xWinsCount = new System.Windows.Forms.Label();
            this.yWinsCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.board.Location = new System.Drawing.Point(75, 74);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(375, 325);
            this.board.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "\'X\' Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "\'O\' Wins:";
            // 
            // xWinsCount
            // 
            this.xWinsCount.AutoSize = true;
            this.xWinsCount.BackColor = System.Drawing.Color.Gray;
            this.xWinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinsCount.ForeColor = System.Drawing.Color.White;
            this.xWinsCount.Location = new System.Drawing.Point(141, 9);
            this.xWinsCount.Name = "xWinsCount";
            this.xWinsCount.Size = new System.Drawing.Size(0, 20);
            this.xWinsCount.TabIndex = 3;
            // 
            // yWinsCount
            // 
            this.yWinsCount.AutoSize = true;
            this.yWinsCount.BackColor = System.Drawing.Color.Gray;
            this.yWinsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yWinsCount.ForeColor = System.Drawing.Color.White;
            this.yWinsCount.Location = new System.Drawing.Point(141, 51);
            this.yWinsCount.Name = "yWinsCount";
            this.yWinsCount.Size = new System.Drawing.Size(0, 20);
            this.yWinsCount.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Draws:";
            // 
            // drawsCount
            // 
            this.drawsCount.AutoSize = true;
            this.drawsCount.BackColor = System.Drawing.Color.Gray;
            this.drawsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsCount.ForeColor = System.Drawing.Color.White;
            this.drawsCount.Location = new System.Drawing.Point(283, 32);
            this.drawsCount.Name = "drawsCount";
            this.drawsCount.Size = new System.Drawing.Size(0, 20);
            this.drawsCount.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 30);
            this.label7.TabIndex = 5;
            this.label7.Text = "Designed By:  ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(200, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ehtesham Mehmood";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(347, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Turn:";
            // 
            // nextTurn
            // 
            this.nextTurn.AutoSize = true;
            this.nextTurn.BackColor = System.Drawing.Color.Gray;
            this.nextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTurn.ForeColor = System.Drawing.Color.White;
            this.nextTurn.Location = new System.Drawing.Point(413, 32);
            this.nextTurn.Name = "nextTurn";
            this.nextTurn.Size = new System.Drawing.Size(0, 20);
            this.nextTurn.TabIndex = 9;
            // 
            // BoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 467);
            this.Controls.Add(this.nextTurn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drawsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yWinsCount);
            this.Controls.Add(this.xWinsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BoardView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIC TAC TOE";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel board;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xWinsCount;
        private System.Windows.Forms.Label yWinsCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label drawsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label nextTurn;
    }
}

