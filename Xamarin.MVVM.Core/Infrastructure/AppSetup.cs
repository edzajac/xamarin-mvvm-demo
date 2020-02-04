using System;
using Autofac;
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
            builder.RegisterType<MainPageViewModel>().SingleInstance();
        }
    }
}
