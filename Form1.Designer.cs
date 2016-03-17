namespace VideoPoker
{
    partial class frmTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTable));
            this.mnuPoker = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pokerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPoker.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPoker
            // 
            this.mnuPoker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokerToolStripMenuItem,
            this.dealToolStripMenuItem});
            this.mnuPoker.Location = new System.Drawing.Point(0, 0);
            this.mnuPoker.Name = "mnuPoker";
            this.mnuPoker.Size = new System.Drawing.Size(805, 24);
            this.mnuPoker.TabIndex = 0;
            this.mnuPoker.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.mnuNewGame.Size = new System.Drawing.Size(152, 22);
            this.mnuNewGame.Text = "New Game";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(152, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // dealToolStripMenuItem
            // 
            this.dealToolStripMenuItem.Name = "dealToolStripMenuItem";
            this.dealToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.dealToolStripMenuItem.Text = "Deal";
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(805, 568);
            this.ControlBox = false;
            this.Controls.Add(this.mnuPoker);
            this.MainMenuStrip = this.mnuPoker;
            this.Name = "frmTable";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

