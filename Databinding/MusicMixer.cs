using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Databinding
{
    class MusicMixer : INotifyPropertyChanged
    {
        private int volume;
        Label label = new Label();

        public MusicMixer(Label label)
        {
            this.label = label;
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (volume != value)
                {
                    volume = value;
                    NotifyPropertyChanged();
                    if (volume > 50)
                    {
                        label.Content = "Musikken er høj";
                    }
                    else
                    {
                        label.Content = "Musikken er lav";
                    }
                }
                volume = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
