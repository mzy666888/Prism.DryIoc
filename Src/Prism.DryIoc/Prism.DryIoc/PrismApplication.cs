using System;
using System.Windows;
using DryIoc;
using Prism.Ioc;

namespace Prism.DryIoc
{
    public abstract class PrismApplication:PrismApplicationBase
    {
        protected virtual Rules CreateContainerRules() => DryIocContainerExtension.DefaultRules;
        protected override IContainerExtension CreateContainerExtension()
        {
            return new DryIocContainerExtension(new Container(CreateContainerRules()));
        }

        protected override void RegisterFrameworkExceptionTypes()
        {
            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(ContainerException));
        }
    }
}