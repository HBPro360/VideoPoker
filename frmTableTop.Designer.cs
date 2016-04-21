namespace VideoPoker
{
    partial class frmTableTop
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableTop));
            this.mnuPoker = new System.Windows.Forms.MenuStrip();
            this.pokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDraw = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblHand = new System.Windows.Forms.Label();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblBetTitle = new System.Windows.Forms.Label();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn75 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.lblBet = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWinTitle = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.mnuPoker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPoker
            // 
            this.mnuPoker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokerToolStripMenuItem,
            this.mnuNewGame,
            this.mnuDraw});
            this.mnuPoker.Location = new System.Drawing.Point(0, 0);
            this.mnuPoker.Name = "mnuPoker";
            this.mnuPoker.Size = new System.Drawing.Size(805, 24);
            this.mnuPoker.TabIndex = 0;
            this.mnuPoker.Text = "menuStrip1";
            // 
            // pokerToolStripMenuItem
            // 
            this.pokerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurchase,
            this.toolStripSeparator1,
            this.mnuExit});
            this.pokerToolStripMenuItem.Name = "pokerToolStripMenuItem";
            this.pokerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pokerToolStripMenuItem.Text = "Poker";
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(143, 22);
            this.mnuPurchase.Text = "Purchase 100";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(143, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.AccessibleName = "";
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(77, 20);
            this.mnuNewGame.Text = "New Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click);
            // 
            // mnuDraw
            // 
            this.mnuDraw.AccessibleName = "";
            this.mnuDraw.Name = "mnuDraw";
            this.mnuDraw.Size = new System.Drawing.Size(46, 20);
            this.mnuDraw.Text = "Draw";
            this.mnuDraw.Click += new System.EventHandler(this.mnuDraw_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.BackColor = System.Drawing.Color.Transparent;
            this.lblHand.Font = new System.Drawing.Font("Showcard Gothic", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand.ForeColor = System.Drawing.Color.White;
            this.lblHand.Location = new System.Drawing.Point(254, 227);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(0, 66);
            this.lblHand.TabIndex = 1;
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMoneyTitle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyTitle.ForeColor = System.Drawing.Color.White;
            this.lblMoneyTitle.Location = new System.Drawing.Point(21, 44);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(68, 20);
            this.lblMoneyTitle.TabIndex = 2;
            this.lblMoneyTitle.Text = "Money";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(90, 44);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(18, 20);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "0";
            // 
            // lblBetTitle
            // 
            this.lblBetTitle.AutoSize = true;
            this.lblBetTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBetTitle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetTitle.ForeColor = System.Drawing.Color.White;
            this.lblBetTitle.Location = new System.Drawing.Point(22, 77);
            this.lblBetTitle.Name = "lblBetTitle";
            this.lblBetTitle.Size = new System.Drawing.Size(39, 20);
            this.lblBetTitle.TabIndex = 4;
            this.lblBetTitle.Text = "Bet";
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(26, 103);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(75, 23);
            this.btn25.TabIndex = 6;
            this.btn25.Text = "25";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(26, 132);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(75, 23);
            this.btn50.TabIndex = 7;
            this.btn50.Text = "50";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn75
            // 
            this.btn75.Location = new System.Drawing.Point(25, 161);
            this.btn75.Name = "btn75";
            this.btn75.Size = new System.Drawing.Size(75, 23);
            this.btn75.TabIndex = 8;
            this.btn75.Text = "75";
            this.btn75.UseVisualStyleBackColor = true;
            this.btn75.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(26, 190);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(75, 23);
            this.btn100.TabIndex = 9;
            this.btn100.Text = "100";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.BackColor = System.Drawing.Color.Transparent;
            this.lblBet.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.ForeColor = System.Drawing.Color.White;
            this.lblBet.Location = new System.Drawing.Point(90, 77);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(18, 20);
            this.lblBet.TabIndex = 10;
            this.lblBet.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 147);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblWinTitle
            // 
            this.lblWinTitle.AutoSize = true;
            this.lblWinTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWinTitle.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTitle.ForeColor = System.Drawing.Color.White;
            this.lblWinTitle.Location = new System.Drawing.Point(177, 44);
            this.lblWinTitle.Name = "lblWinTitle";
            this.lblWinTitle.Size = new System.Drawing.Size(91, 20);
            this.lblWinTitle.TabIndex = 16;
            this.lblWinTitle.Text = "Winnings";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(274, 44);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(18, 20);
            this.lblWin.TabIndex = 17;
            this.lblWin.Text = "0";
            this.lblWin.Click += new System.EventHandler(this.lblWin_Click);
            // 
            // frmTableTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 568);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblWinTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBet);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn75);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.lblBetTitle);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblMoneyTitle);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.mnuPoker);
            this.MainMenuStrip = this.mnuPoker;
            this.Name = "frmTableTop";
            this.Text = "HammBone\'s Awesome Poker Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTableTop_Load);
            this.mnuPoker.ResumeLayout(false);
            this.mnuPoker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPoker;
        private System.Windows.Forms.ToolStripMenuItem pokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDraw;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.Label lblMoneyTitle;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblBetTitle;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn75;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblWinTitle;
        private System.Windows.Forms.Label lblWin;
    }
}

