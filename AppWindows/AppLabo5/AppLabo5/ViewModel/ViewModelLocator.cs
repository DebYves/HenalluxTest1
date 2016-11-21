﻿
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;


namespace AppLabo5.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<MainViewModel>();
            /*
            NavigationService navigationPages = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationPages);
            navigationPages.Configure("MainPage", typeof(MainPage));*/
        }

        public MainViewModel Main
        {
            get { return ServiceLocator.Current.GetInstance<MainViewModel>(); }
        }

    }
}