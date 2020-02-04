using System;
using Autofac;
using Xamarin.MVVM.Core.Infrastructure;

namespace Xamarin.MVVM.Droid.Infrastructure
{
    public class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder builder)
        {
            base.RegisterDependencies(builder);

            //Register any additional dependencies here for Android specific implementation
        }
    }
}
