using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using HandyControl.Controls;
using WPF.Models;

namespace WPF.ViewModels
{
    /// <summary>  
    /// Initializes a new instance of the MainViewModel class.  
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        #region Constructor
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                WindowTitle = "登录界面(Design Mode)";
                LoginProperties.UserName = "190902";
                LoginProperties.Password = "190902";
                LoginProperties.LoadingCircle = "Visible";
            }
            else
            {
                WindowTitle = "登录界面";
                LoginProperties.LoadingCircle = "Hidden";
            }
            RaisePropertyChanged(nameof(WindowTitle));
        }
        #endregion

        #region Properties

        #region DTO
        public LoginModel LoginProperties { get; set; } = new LoginModel();
        #endregion

        public string WindowTitle { get; set; }
        #endregion


        #region Commands
        private RelayCommand loginCommand;
        public RelayCommand LoginCommand => loginCommand ?? (loginCommand = new RelayCommand(Login));
        #endregion

        #region Methods
        private void Login()
        {
            LoginProperties.LoadingCircle = "Visible";//显示LoadingCircle
            var t = Task.Run(() =>
            {
                Thread.Sleep(5000);//模拟耗时操作
                LoginProperties.LoadingCircle = "Hidden";//隐藏LoadingCircle
                MessageBox.Show($"用户名：{LoginProperties.UserName}\n密码：{LoginProperties.Password}");
            });
            //t.Wait();
            
        }
        #endregion





    }
}
