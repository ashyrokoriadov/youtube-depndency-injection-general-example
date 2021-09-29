using Autofac;

namespace DependencyInjectionSampeApp.IoC
{
    static class ContainerPreparer
    {
        private static object _syncObject = new object();

        private static IContainer _container;
        public static IContainer Container
        {
            get
            {
                lock (_syncObject)
                {
                    return _container ?? (_container = Builder.Build()); 
                }
            }
        }
  
        private static ContainerBuilder _builder;
        public static ContainerBuilder Builder => _builder ?? (_builder = new ContainerBuilder());
    }
}
