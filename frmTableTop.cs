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



        private void EnablePBtn()
        {
            btn25.Enabled = true;
            btn50.Enabled = true;
            btn75.Enabled = true;
            btn100.Enabled = true;
        }
        private void DisablePBtn()
        {
            btn25.Enabled = false;
            btn50.Enabled = false;
            btn75.Enabled = false;
            btn100.Enabled = false;
        }
        private void EnableNBtn()
        {
            btnN25.Enabled = true;
            btnN50.Enabled = true;
            btnN75.Enabled = true;
            btnN100.Enabled = true;
        }
        private void DisableNBtn()
        {
            btnN25.Enabled = false;
            btnN50.Enabled = false;
            btnN75.Enabled = false;
            btnN100.Enabled = false;
        }

        public frmTableTop()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you absolutely sure you want to exit?", "You're Leaving?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("      You can never leave! MUAHAHAHAHAHAHA");
                MessageBox.Show("        Just Kidding");
                Application.Exit();
            }
            
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
            this.lblHand.Text = hand.Evaluate();
            DisableNG();
            
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            hand.Draw(deck);
            hand.Show();
            this.lblHand.Text = hand.Evaluate();
            EnableNG();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //double money = Double.Parse(lblMoney.Text);
            //Button btn = (Button)sender;
            //double value = Double.Parse(btn.Tag.ToString());
            int money = Convert.ToInt32(lblMoney.Text);
            int betV = Convert.ToInt32(lblBet.Text);

            Button btn = (Button)sender;

            int value = Convert.ToInt32(btn.Text);

            if (money - value <= 0)
            {
                money -= value;

                lblMoney.Text = money.ToString();

                int bet = Convert.ToInt32(lblBet.Text);

                bet += value;

                lblBet.Text = bet.ToString();

                DisablePBtn();
            }
            else if (money - value >= 0)
            {
                money -= value;

                lblMoney.Text = money.ToString();

                int bet = Convert.ToInt32(lblBet.Text);

                bet += value;

                lblBet.Text = bet.ToString();

                EnableNBtn();
            }
            if (betV - value <= 0)
            {
                money -= value;

                lblMoney.Text = money.ToString();

                int bet = Convert.ToInt32(lblBet.Text);

                bet += value;

                lblBet.Text = bet.ToString();

                DisableNBtn();
            }
            if (betV - value <= 0)
            {
                money -= value;

                lblMoney.Text = money.ToString();

                int bet = Convert.ToInt32(lblBet.Text);

                bet += value;

                lblBet.Text = bet.ToString();

                DisableNBtn();
            }

        }
        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            int money = Convert.ToInt32(lblMoney.Text);
            money += 100;
            lblMoney.Text = money.ToString();
            EnablePBtn();
        }
    }
}
