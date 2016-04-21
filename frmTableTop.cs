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
        List<Button> buttons;
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

        public frmTableTop()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you absolutely sure you want to exit?", "You're Leaving?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void frmTableTop_Load(object sender, EventArgs e)
        {
            EnableNG();
            buttons = new List<Button>();
            buttons.Add(btn25);
            buttons.Add(btn50);
            buttons.Add(btn75);
            buttons.Add(btn100);

            decimal bank = decimal.Parse(lblMoney.Text);
            if (bank == 0)
            {
                ChangeButtonStatus(false);
                mnuNewGame.Enabled = false;
            }
            else
            {
                ChangeButtonStatus(true);

                mnuNewGame.Enabled = true;
            }

        }

        private void ChangeButtonStatus(bool status)
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = status;
            }
        }

        private void mnuNewGame_Click(object sender, EventArgs e)
        {
            if (deck != null)
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
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;
            lblWin.Text = 0.ToString();
            DisableNG();
            DisablePBtn();

        }

        private void Calculate(Values multiplier)
        {
            double bet = double.Parse(this.lblBet.Text);
            double cash = bet * (double)multiplier;
            double money = double.Parse(lblMoney.Text);
            money += cash;
            lblMoney.Text = string.Format("{0:F}", money);
            lblWin.Text = cash.ToString();
            
        }

        private void mnuDraw_Click(object sender, EventArgs e)
        {
            hand.Draw(deck);
            hand.Show();
            HandValue result = hand.Evaluate();
            this.lblHand.Text = result.Description;

            Calculate(result.Multiplier);
            lblBet.Text = 0.ToString();
            //EnableNG();
            EnablePBtn();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            double money = Double.Parse(lblMoney.Text);
            Button btn = (Button)sender;
            double value = Double.Parse(btn.Text.ToString());

            if(money - value >= 0)
            {
                money -= value;
                lblMoney.Text = money.ToString();
                double bet = Convert.ToDouble(lblBet.Text);
                bet = value;
                lblBet.Text = bet.ToString();
            }
            DisablePBtn();
            EnableNG();
           

        }
        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(lblMoney.Text);
            money += 100;
            lblMoney.Text = string.Format("{0:F}", money);
            double bank = double.Parse(lblMoney.Text);
            if (bank > 0)
            {
                this.mnuNewGame.Enabled = true;
                this.ChangeButtonStatus(true);
            }
            DisableNG();
            //lblMoney.Text = money.ToString();
            //EnablePBtn();
        }

        private void lblWin_Click(object sender, EventArgs e)
        {

        }
    }
}
