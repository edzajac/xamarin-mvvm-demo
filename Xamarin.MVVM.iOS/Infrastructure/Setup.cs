using System;
using Autofac;
using Xamarin.MVVM.Core.Infrastructure;

namespace Xamarin.MVVM.iOS.Infrastructure
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder builder)
        {
            base.RegisterDependencies(builder);

            //Register any additional dependencies here for iOS specific implementation
        }
    }
}
