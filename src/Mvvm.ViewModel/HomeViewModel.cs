using PropertyChanged;

namespace Mvvm.ViewModel
{
    [ImplementPropertyChanged]
    public class HomeViewModel : BaseViewModel
    {
        public string Message { get; set; }

        public HomeViewModel()
        {
            Message = "hello there!";
        }
    }
}
