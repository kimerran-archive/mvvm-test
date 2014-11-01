using System;
using System.Linq;
using Mvvm.DataAccess;
using Mvvm.ViewModel.Common;
using PropertyChanged;

namespace Mvvm.ViewModel
{

    [ImplementPropertyChanged]
    public class LoginViewModel : BaseViewModel
    {
        private readonly UserRepository _userRepository;
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public MvvmCommand Login { get; set; }

        public LoginViewModel()
        {
            _userRepository = new UserRepository();
            InitCommands();
        }

        private Action<object> LoginAction()
        {
            return (param =>
            {
                var res = _userRepository.FindAll()
                       .Where(o => o.Username == Username && o.Password == Password);

                if (res.Any())
                {
                    Status = "logged in";

                    MainViewModel.Instance().CurrentViewModel = new HomeViewModel();

                }
                else
                {
                    Status = "login failed.";
                }
            });
        }

       
        private void InitCommands()
        {
            Login = new MvvmCommand(LoginAction());
        }

        //private Action<object> LoginAction()
        //{
        //    return () =>
        //    {
        //        var res = _userRepository.FindAll().Where(o => o.Username == Username && o.Password == Password);
        //        if (res.Any())
        //        {
        //            Status = "logged in";
        //        }
        //        else
        //        {
        //            Status = "login failed.";
        //        }

        //    };
        //}
    }


}
