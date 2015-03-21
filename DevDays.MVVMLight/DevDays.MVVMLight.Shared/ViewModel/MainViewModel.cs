using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DevDays.MVVMLight.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                RaisePropertyChanged();
                SayHello.RaiseCanExecuteChanged();
            }
        }

        private string _message;

        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                RaisePropertyChanged();
            }
        }

        private RelayCommand _sayHello;

        public RelayCommand SayHello
        {
            get
            {
                if (_sayHello == null)
                {
                    _sayHello = new RelayCommand(() =>
                    {
                        Message = string.Format("Hello {0}", Name);
                    }, () => !string.IsNullOrEmpty(Name));
                }

                return _sayHello;
            }
        }
    }
}