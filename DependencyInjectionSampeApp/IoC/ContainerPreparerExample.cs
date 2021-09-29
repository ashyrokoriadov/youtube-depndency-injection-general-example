using Autofac;
using DependencyInjectionSampeApp.Factories;
using DependencyInjectionSampeApp.Implementations;
using DependencyInjectionSampeApp.Interfaces;

namespace DependencyInjectionSampeApp.IoC
{
    static class ContainerPreparerExample
    {
        public static void Prepare(ContainerBuilder containerBuilder)
        {
            //RegisterSimpleFactory(containerBuilder);
            RegisterFactoryWithJsonConfig(containerBuilder);
            RegisterCalculator(containerBuilder);
            RegisterJsonConfigReader(containerBuilder);
        }

        private static void RegisterSimpleFactory(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CalculatorFactory>()
                .As<ICalculatorFactory>();
        }

        private static void RegisterFactoryWithJsonConfig(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<CalculatorFactoryWithJsonConfigReader>()
                .As<ICalculatorFactory>();
        }

        private static void RegisterCalculator(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<Printer>().As<IPrinter>();
            containerBuilder.RegisterType<Logger>().As<ILogger>();
            containerBuilder.RegisterType<XmlConfigurationReader>().As<IConfigurationReader>();
            containerBuilder.RegisterType<DatabaseConnector>().As<IConnector>();
            containerBuilder.RegisterType<Calculator>().As<ICalculator>();             
        }

        private static void RegisterJsonConfigReader(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<JsonConfigurationReader>().As<IConfigurationReader>();
        }
    }
}
