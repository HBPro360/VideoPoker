using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VideoPoker
{
    class Card : IDisposable
    {

        #region Private Members

        private string _Suit = string.Empty;
        private uint _Value = 0;
        private Image _FImage = null;
        private Image _BImage = null;
        private Image _HImage = null;
        private PictureBox _Card = null;
        private bool _IsHeld = false;


        #endregion

        #region Public Properties

        public PictureBox pCard
        {
            get
            {
                return _Card;
            }
        }
        public string Suit
        {
            get
            {
                return _Suit;
            }
            set
            {
                _Suit = value;
            }
        }

        public uint Value
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = value;
            }
        }
        public Image FImage
        {
            get
            {
                return _FImage;
            }
            set
            {
                _FImage = value;
            }
        }
        public Image BImage
        {
            get
            {
                return _BImage;
            }
            set
            {
                _BImage = value;
            }
        }
        public Image HImage
        {
            get
            {
                return _HImage;
            }
            set
            {
                _HImage = value;
            }
        }
        public bool IsHeld
        {
            get
            {
                return _IsHeld;
            }
            set
            {
                _IsHeld = value;
            }
        }
        #endregion

        #region  Private Methods 

        #endregion

        #region  Public Methods 

        #endregion

        #region  Public Events 

        private void _Card_MouseClick(object sender, MouseEventArgs e)
        {
            _IsHeld = !_IsHeld;
            if (_IsHeld == true)
            {
                _Card.Image = _HImage;
            }
            else
            {
                _Card.Image = _FImage;
            }
        }

        private void _Card_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void _Card_MouseEnter(object sender, EventArgs e)
        {
            
        }

        #endregion


        #region  Public Event Handlers 

        #endregion

        #region Construction 
        public Card()
        {
            _Card = new PictureBox();
            _Card.MouseEnter += _Card_MouseEnter;
            _Card.MouseLeave += _Card_MouseLeave;
            _Card.MouseClick += _Card_MouseClick;
            
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Card() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
        #endregion
    }
}
