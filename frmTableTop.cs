using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPoker
{
    public partial class frmTableTop : Form
    {
        Random rnd = new Random();
        Deck deck;
        Hand hand;
        public frmTableTop()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTableTop_Load(object sender, EventArgs e)
        {
            deck = new Deck(this, rnd);
            deck.Show();
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                hand.Deal = deck.Deal();
            }
            hand.Show();
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            hand.Draw(deck);
            hand.Show();
        }
    }
}
