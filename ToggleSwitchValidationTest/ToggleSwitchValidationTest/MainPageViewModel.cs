using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToggleSwitchValidationTest
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private bool _is_my_switch_toggled = false;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel()
        {
            //empty
        }

        public bool IsMySwitchToggled
        {
            get
            {
                return _is_my_switch_toggled;
            }
            set
            {
                _is_my_switch_toggled = value;
                NotifyPropertyChanged("IsMySwitchToggled");
            }
        }

        public void NotifyPropertyChanged (string propertyName)
        {
            PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
        }
    }
}
