using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace DevDays.MVVMLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
        }

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