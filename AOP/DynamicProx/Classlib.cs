using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;

namespace TestOutput
{
    public interface IPlayable
    {
        void Play();
    }

    public class Animal : IPlayable
    {
        public virtual void Play()
        {
            Console.WriteLine("Animal.Play");
        }
    }

    public class Dog : Animal
    {
        public override void Play()
        {
            Console.WriteLine("Dog.Play");
        }
    }

    public interface IRunable
    {
        void Run();
    }

    public class RunAbility : IRunable
    {
        public void Run()
        {
            Console.WriteLine("RunAbility.Run");
        }
    }

    public class AnimalInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Before AnimalInterceptor.Intercept");
            if (invocation.InvocationTarget != null)
            {
                invocation.Proceed();
            }
            Console.WriteLine("After AnimalInterceptor.Intercept");
        }
    }
}
