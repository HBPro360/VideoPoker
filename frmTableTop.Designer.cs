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
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blargToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.blargToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPoker.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPoker
            // 
            this.mnuPoker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokerToolStripMenuItem,
            this.dealToolStripMenuItem,
            this.blargToolStripMenuItem,
            this.blargToolStripMenuItem1});
            this.mnuPoker.Location = new System.Drawing.Point(0, 0);
            this.mnuPoker.Name = "mnuPoker";
            this.mnuPoker.Size = new System.Drawing.Size(805, 24);
            this.mnuPoker.TabIndex = 0;
            this.mnuPoker.Text = "menuStrip1";
            // 
            // pokerToolStripMenuItem
            // 
            this.pokerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.mnuExit});
            this.pokerToolStripMenuItem.Name = "pokerToolStripMenuItem";
            this.pokerToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.pokerToolStripMenuItem.Text = "Poker";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(132, 22);
            this.mnuNewGame.Text = "New Game";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(132, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // dealToolStripMenuItem
            // 
            this.dealToolStripMenuItem.Name = "dealToolStripMenuItem";
            this.dealToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dealToolStripMenuItem.Text = "Deal";
            // 
            // blargToolStripMenuItem
            // 
            this.blargToolStripMenuItem.Name = "blargToolStripMenuItem";
            this.blargToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(805, 544);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmTableTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(805, 568);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mnuPoker);
            this.MainMenuStrip = this.mnuPoker;
            this.Name = "frmTableTop";
            this.Load += new System.EventHandler(this.frmTableTop_Load);
            this.mnuPoker.ResumeLayout(false);
            this.mnuPoker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPoker;
        private System.Windows.Forms.ToolStripMenuItem pokerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dealToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem blargToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blargToolStripMenuItem1;
    }
}

