using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace TestOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n*************InterfaceProxyWithTargetInterface*************\n");
            var generator = new ProxyGenerator();
            var animal = generator.CreateInterfaceProxyWithTargetInterface<IPlayable>(new Dog(), new AnimalInterceptor());
            animal.Play();
            Console.WriteLine(animal.GetType());
            Console.WriteLine(animal.GetType().BaseType);

            var compositeField = animal.GetType().GetField("__target");
            Console.WriteLine(compositeField);

            foreach (var interfaceType in animal.GetType().GetInterfaces())
            {
                Console.WriteLine(interfaceType);
            }
            Console.Read();

        }
    }
}
