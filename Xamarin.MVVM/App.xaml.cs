﻿using Xamarin.Forms;
using Xamarin.MVVM.Core.Infrastructure;
using Xamarin.MVVM.Views;

namespace Xamarin.MVVM
{
    public partial class App : Application
    {
        public App(AppSetup setup)
        {
            AppContainer.Container = setup.CreateContainer();

            InitializeComponent();

            MainPage = new NavigationPage(new MainPageView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
