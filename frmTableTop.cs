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
            Deck deck = new Deck(this, rnd);
            for (int i = 0; i<52;i++)
                this.flowLayoutPanel1.Controls.Add(deck.Deal().pCard);
        }
    }
}
