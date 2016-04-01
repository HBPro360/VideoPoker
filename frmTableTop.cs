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
        private void EnableNG()
        {
            mnuNewGame.Enabled = true;
            mnuDraw.Enabled = false;
        }

        private void DisableNG()
        {
            mnuNewGame.Enabled = false;
            mnuDraw.Enabled = true;
        }

        public frmTableTop()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("      You can never leave! MUAHAHAHAHAHAHA");
            MessageBox.Show("        Just Kidding");
            Application.Exit();
        }

        private void frmTableTop_Load(object sender, EventArgs e)
        {

            EnableNG();
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            if(deck!=null)
            {
                deck.Dispose();
            }
            deck = new Deck(this, rnd);
            deck.Show();
            
            if (hand != null)
            {
                hand.Dispose();
            }
            hand = new Hand();
            for (int i = 0; i < 5; i++)
            {
                hand.Deal = deck.Deal();
            }
            hand.Show();
            DisableNG();
            
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            hand.Draw(deck);
            hand.Show();
            EnableNG();
        }


    }
}
