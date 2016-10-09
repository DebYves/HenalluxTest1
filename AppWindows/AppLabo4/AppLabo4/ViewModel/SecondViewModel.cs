using Windows.UI.Xaml.Navigation;
using AppLabo4.Model;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;

namespace AppLabo4.ViewModel
{
    public class SecondViewModel
    {
        //Plaçez une propriété correspondant à l’élément sélectionné de la page principale et la
        //navigation
        public Student SelectedStudent { get; set; }

        private INavigationService _navigationService;

        [PreferredConstructor]
        public SecondViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student) e.Parameter;
        }
    }
}