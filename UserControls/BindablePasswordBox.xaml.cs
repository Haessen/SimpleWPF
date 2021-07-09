using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.UserControls
{
    /// <summary>
    /// BindablePasswordBox.xaml 的交互逻辑
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        #region Constructor
        public BindablePasswordBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Fields
        private bool _isPasswordChanging;
        #endregion

        #region Properties
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        #endregion

        #region DependencyProperties
        // Using a DependencyProperty as the backing store for Password.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindablePasswordBox), new PropertyMetadata(string.Empty, PasswordPropertyChanged));
        #endregion

        #region Methods
        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is BindablePasswordBox passwordBox)
            {
                passwordBox.UpdatePassword();
            }
        }
        private void UpdatePassword()
        {
            if (!_isPasswordChanging)
            {
                bindablePasswordBox.Password = Password;
            }
        }
        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = bindablePasswordBox.Password;
            _isPasswordChanging = false;
        }


        #endregion


    }
}
