using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Mandatory3
{
    class Piece : INotifyPropertyChanged
    {
        private int pieceValue;

        public int PieceValue
        {
            get { return pieceValue; }
            set
            {
                pieceValue = value;
                if (pieceValue > 0)
                    BackGroundColor = Brushes.Blue;
                else
                    BackGroundColor = Brushes.Beige;
                NotifyPropertyChanged();
            }
        }
        private Brush backGroundColor;

        public Brush BackGroundColor
        {
            get { return backGroundColor; }
            private set
            {
                backGroundColor = value;
                NotifyPropertyChanged();
            }
        }

        public Piece(int startValue)
        {
            PieceValue = startValue;
        }

        #region Code to handle property changed
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
