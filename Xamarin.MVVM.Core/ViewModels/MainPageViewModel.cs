using Xamarin.MVVM.Core.Interfaces;
using Xamarin.MVVM.Core.MVVM;

namespace Xamarin.MVVM.Core.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly IWelcomeService _welcomeService;

        private string _welcomeText;

        public string WelcomeText
        {
            get => _welcomeText;
            set => RaiseAndUpdate(ref _welcomeText, value);
        }

        public MainPageViewModel(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService;

            WelcomeText = _welcomeService.GetWelcomeStatement();
        }

    }
}
