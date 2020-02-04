using System;
using Autofac;
using Xamarin.MVVM.Core.Interfaces;
using Xamarin.MVVM.Core.Services;
using Xamarin.MVVM.Core.ViewModels;

namespace Xamarin.MVVM.Core.Infrastructure
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            RegisterDependencies(builder);

            return builder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            // Services
            builder.RegisterType<WelcomeService>().As<IWelcomeService>().SingleInstance();

            // ViewModels
            builder.RegisterType<MainPageViewModel>().UsingConstructor(typeof(IWelcomeService)).SingleInstance();
        }
    }
}
