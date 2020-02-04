using System.Threading;
using Autofac;
using Xamarin.Forms;
using Xamarin.MVVM.Core.Infrastructure;
using Xamarin.MVVM.Core.MVVM;

namespace Xamarin.MVVM.MVVM
{
    public class BaseView<T> : ContentPage where T : BaseViewModel
    {
        private readonly T _viewModel;

        private long _initialized;

        public T ViewModel
        {
            get => _viewModel;
        }

        //public T ViewModel { get; protected set; } = new T();

        /// <summary>
        /// Initializes a new instance of the BaseView class.
        /// </summary>
        public BaseView()
        {
            _viewModel = AppContainer.Container.Resolve<T>();

            NavigationPage.SetBackButtonTitle(this, "Back");

            BindingContext = _viewModel;

            Title = ViewModel.Title;
        }

        /// <summary>
        /// Overrides the OnAppearing method and calls the ViewModel's InitAsync method.
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (Interlocked.CompareExchange(ref _initialized, 1, 0) == 0)
            {
                await ViewModel.InitAsync();
            }
        }
    }
}

