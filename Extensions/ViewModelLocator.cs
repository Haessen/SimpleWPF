/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:" x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using WPF.ViewModels;

namespace WPF.Extensions
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        #region ViewModels
        public static MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();
        #endregion

        #region Views

        #endregion

        #region Constructor
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }
        #endregion


        /*-------------------------------------- Public Methods --------------------------------------*/
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }

        /*-------------------------------------- Private Methods -------------------------------------*/

    }
}
