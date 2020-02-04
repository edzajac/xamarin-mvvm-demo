using System;
using Xamarin.MVVM.Core.Interfaces;

namespace Xamarin.MVVM.Core.Services
{
    public class WelcomeService : IWelcomeService
    {
        public string GetWelcomeStatement()
        {
            return "Welcome to Xamarin.Forms!";
        }
    }
}
