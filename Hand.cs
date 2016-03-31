using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace VideoPoker
{
    public class Hand
    {

        #region Private Members

        List<Card> _Cards = null;
        List<Card> _SCards = null;
        
        #endregion

        #region Public Properties

        public Card Deal
        {
            set
            {
                value.Bouncable = false;
                value.Holdable = true;
                _Cards.Add(value);
                _SCards.Add(value);
            }
        }

        #endregion

        #region  Private Methods 



        #endregion

        #region  Public Methods 

        public void Show()
        {
            int x = 200;
            int y = 500;
            foreach (Card card in _Cards)
            {
                card.Flip();
                Point location = new Point(x, y);
                card.pCard.Location = location;
                //card.pCard.BringToFront();
                x += (card.pCard.Width + 10);
            }
        }
        public void Draw(Deck deck)
        {
            int x = 50;
            int y = 50;
            for (int i = 0; i < _Cards.Count; i++)
            {
                if (_Cards[i].IsHeld == false)
                {
                    _Cards[i].Dispose();
                    _Cards[i] = deck.Deal();
                    _Cards[i].Flip();
                    _Cards[i].Bouncable = false;
                }
                _Cards[i].Holdable = false;
            }
            //Cannot use because "card" obtains new value after before passing through second foreach loop
            //foreach (Card card in _Cards)
            //{
            //    if (card.IsHeld == false)
            //    {
            //        card = deck.Deal();
            //    }
            //}

            _SCards.Clear();

            foreach(Card card in _Cards)
            {
                _SCards.Add(card);
            }
        }

        private void Dispose()
        {
            foreach(Card card in _Cards)
            {
                card.Dispose();
            }
        }

        #endregion

        #region  Public Events 



        #endregion

        #region  Public Event Handlers 



        #endregion

        #region Construction 

        public Hand()
        {
            if(_Cards != null)
            {
                Dispose();
            }
            _Cards = new List<Card>();
            _SCards = new List<Card>();
            
        }

        #endregion

    }
}
