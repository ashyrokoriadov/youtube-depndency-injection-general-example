using Autofac;
using DependencyInjectionSampeApp.Factories;
using DependencyInjectionSampeApp.Interfaces;
using DependencyInjectionSampeApp.IoC;
using System;

namespace DependencyInjectionSampeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowFactoryExample(new CalculatorFactory());
            //ShowFactoryExample(new CalculatorFactoryWithJsonConfigReader());
            //ShowDependencyInjectionExampleWithFactory();
            ShowDependencyInjectionExampleWithCalculator();

            Console.ReadKey();
        }

        static void ShowFactoryExample(ICalculatorFactory calculatorFactory)
        {
            Console.WriteLine($"Пример с использованием фабрики {calculatorFactory.GetType()}.");
            Console.WriteLine("");

            var calculator = calculatorFactory.Order();
            calculator.Calculate();

            Console.WriteLine("");
        }

        static void ShowDependencyInjectionExampleWithFactory()
        {
            Console.WriteLine($"Пример с использованием внедрение зависимости с фабрикой.");
            Console.WriteLine("");

            using (var scope = PrepareContainer().BeginLifetimeScope())
            {
                var calculatorFactory = scope.Resolve<ICalculatorFactory>();
                ShowFactoryExample(calculatorFactory);
            }

            Console.WriteLine("");
        }

        static void ShowDependencyInjectionExampleWithCalculator()
        {
            Console.WriteLine($"Пример с использованием внедрение зависимости с калькулятором.");
            Console.WriteLine("");

            using (var scope = PrepareContainer().BeginLifetimeScope())
            {
                var calculator = scope.Resolve<ICalculator>();
                calculator.Calculate();
            }

            Console.WriteLine("");
        }

        static IContainer PrepareContainer()
        {
            var builder = ContainerPreparer.Builder;
            ContainerPreparerExample.Prepare(builder);
           return ContainerPreparer.Container;
        }
    }
}
