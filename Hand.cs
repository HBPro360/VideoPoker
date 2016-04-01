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

        public bool RFlush()
        {
            bool result = false;
            if ((_SCards[0].Value==1) && (_SCards[1].Value==10) && (_SCards[2].Value ==11) && (_SCards[3].Value ==12) 
                && (_SCards[4].Value ==13)
                && (_SCards[0].Suit == _SCards[1].Suit) && (_SCards[1].Suit == _SCards[2].Suit)
                && (_SCards[2].Suit == _SCards[3].Suit) && (_SCards[3].Suit == _SCards[4].Suit))
            {
                result = true;
            }
            return result;
        }
        public bool SFlush()
        {
            bool result = false;
            if ((_SCards[0].Suit == _SCards[1].Suit) && (_SCards[1].Suit == _SCards[2].Suit)
                && (_SCards[2].Suit == _SCards[3].Suit) && (_SCards[3].Suit == _SCards[4].Suit)
                && (_SCards[0].Value + 1 == _SCards[1].Value) && (_SCards[1].Value + 1 == _SCards[2].Value)
                && (_SCards[2].Value + 1 == _SCards[3].Value) && (_SCards[3].Value + 1 == _SCards[4].Value))
            {
                result = true;
            }
            return result;
        }
        public bool FourKind()
        {
            bool result = false;
            if ((_SCards[0].Value == _SCards[1].Value) && (_SCards[1].Value == _SCards[2].Value)
                && (_SCards[2].Value == _SCards[3].Value))
            {
                result = true;
            }
            else if ((_SCards[1].Value == _SCards[2].Value) && (_SCards[2].Value == _SCards[3].Value)
                && (_SCards[3].Value == _SCards[4].Value))
            {
                result = true;
            }
                return result;
        }
        public bool FullHouse()
        {
            bool result = false;
            if ((_SCards[0].Value == _SCards[1].Value) && (_SCards[1].Value == _SCards[2].Value) 
                && (_SCards[3].Value == _SCards[4].Value))
            {
                result = true;
            }
            else if ((_SCards[2].Value == _SCards[3].Value) && (_SCards[3].Value == _SCards[4].Value) 
                && (_SCards[0].Value == _SCards[1].Value))
            {
                result = true;
            }
            return result;
        }
        public bool Flush()
        {
            bool result = false;
            if ((_SCards[0].Suit == _SCards[1].Suit) && (_SCards[1].Suit == _SCards[2].Suit) 
                && (_SCards[2].Suit == _SCards[3].Suit) && (_SCards[3].Suit == _SCards[4].Suit))
            {
                result = true;
            }
            return result;
        }
        public bool Straight()
        {
            bool result = false;
            if ((_SCards[0].Value + 1 == _SCards[1].Value) && (_SCards[1].Value + 1 == _SCards[2].Value)
                && (_SCards[2].Value + 1 == _SCards[3].Value) && (_SCards[3].Value + 1 == _SCards[4].Value))
            {
                result = true;
            }
                return result;
        }
        public bool ThreeKind()
        {
            bool result = false;
            if ((_SCards[0].Value == _SCards[1].Value) && (_SCards[1].Value == _SCards[2].Value))
            {
                result = true;
            }
            else if ((_SCards[1].Value == _SCards[2].Value) && (_SCards[2].Value == _SCards[3].Value))
            {
                result = true;
            }
            else if ((_SCards[2].Value == _SCards[3].Value) && (_SCards[3].Value == _SCards[4].Value))
            {
                result = true;
            }
            return result;
        }
        public bool TwoPair()
        {
            bool result = false;
            if ((_SCards[0].Value == _SCards[1].Value) && (_SCards[2].Value == _SCards[3].Value))
            {
                result = true;
            }
            else if ((_SCards[1].Value == _SCards[2].Value) && (_SCards[3].Value == _SCards[4].Value))
            {
                result = true;
            }
            else if ((_SCards[0].Value == _SCards[1].Value) && (_SCards[3].Value == _SCards[4].Value))
            {
                result = true;
            }
            return result;
        }
        public bool Pair()
        {
            bool result = false;
            if (_SCards[0].Value == _SCards[1].Value)
            {
                result = true;
            }
            else if (_SCards[1].Value == _SCards[2].Value)
            {
                result = true;
            }
            else if (_SCards[2].Value == _SCards[3].Value)
            {
                result = true;
            }
            else if (_SCards[3].Value == _SCards[4].Value)
            {
                result = true;
            }
            return result;
        }
        private void Sort()
        {
            bool swapped = true;

            do
            {
                swapped = false;
                for (int i = 0; i < _SCards.Count - 1; i++)
                {
                    if (_SCards[i].Value > _SCards[i + 1].Value)
                    {
                        Card temp = _SCards[i];
                        _SCards[i] = _SCards[i + 1];
                        _SCards[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
        }
        #endregion

        #region  Public Methods 

        public string Evaluate()
        {
            Sort();

            string result = string.Empty;
            if (RFlush()==true)
            {
                result = "Royal Flush";
            }
            else if (SFlush() == true)
            {
                result = "Straight Flush";
            }
            else if (FourKind() == true)
            {
                result = "Four of a Kind";
            }
            else if (FullHouse()== true)
            {
                result = "Full House";
            }
            else if (Flush()== true)
            {
                result = "Flush";
            }
            else if (Straight()== true)
            {
                result = "Straight";
            }
            else if (ThreeKind()== true)
            {
                result = "Three of a Kind";
            }
            else if (TwoPair()== true)
            {
                result = "Two Pair";
            }
            else if (Pair()== true)
            {
                result = "Pair";
            }
            else
            {
                result = "High Card";
            }
            return result;
        }

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

        public void Dispose()
        {
            foreach (Card card in _Cards)
            {
                card.Dispose();
                Application.DoEvents();
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

            _Cards = new List<Card>();
            _SCards = new List<Card>();
            
        }

        #endregion

    }
}
