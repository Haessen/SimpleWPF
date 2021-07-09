using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Models
{
    public class LoginModel : ViewModelBase
    {
        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                RaisePropertyChanged(nameof(UserName));
            }
        }
        private string _loadingCircle;
        public string LoadingCircle
        {
            get => _loadingCircle;
            set
            {
                _loadingCircle = value;
                RaisePropertyChanged(nameof(LoadingCircle));
            }
        }
        public string Password { get; set; }
    }
}
