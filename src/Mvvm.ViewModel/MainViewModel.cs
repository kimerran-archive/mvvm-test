using Mvvm.ViewModel.Common;
using PropertyChanged;

namespace Mvvm.ViewModel
{
    [ImplementPropertyChanged]
    public class MainViewModel : BaseViewModel
    {
        private static MainViewModel _instance;
        public BaseViewModel CurrentViewModel { get; set; }
        public MvvmCommand ShowHomeView { get; set; }
        public MvvmCommand ShowLoginView { get; set; }
        public MainViewModel()
        {
            InitCommands();
        }

        public static MainViewModel Instance()
        {
            if (_instance == null)
            {
                _instance = new MainViewModel();
            }
            return _instance;
        }

        private void InitCommands()
        {
            ShowHomeView = new MvvmCommand(p => { Instance().CurrentViewModel = new HomeViewModel(); });
            ShowLoginView = new MvvmCommand(p => { Instance().CurrentViewModel = new LoginViewModel(); });
        }
    }
}
