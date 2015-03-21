using Caliburn.Micro;

namespace DevDays.CaliburnMicro.ViewModels
{
    public class MainViewModel : Screen
    {
	    protected override void OnActivate()
	    {
		    base.OnActivate();
	    }

	    protected override void OnInitialize()
	    {
		    base.OnInitialize();
	    }

	    private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        private string _message;

        public string Message
        {
            get {return _message;}
            set
            {
                _message = value;
                NotifyOfPropertyChange(() => Message);
            }
        }

        public bool CanSayHello
        {
            get
            {
                return !string.IsNullOrEmpty(Name);
            }
            
        }

        public void SayHello()
        {
            Message = string.Format("Hello {0}", Name);
        }
    }
}
