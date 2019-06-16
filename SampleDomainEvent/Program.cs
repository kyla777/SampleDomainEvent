using System;
using SampleDomainEvent.Infrastructure;
using SampleDomainEvent.Interfaces;
using SampleDomainEvent.Entities;
using SampleDomainEvent.Events;

namespace SampleDomainEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            // IoC Container (a.k.a. DI Container) is a framework for implementing automatic 
            // dependency injection. It manages object creation and it's life-time, and also 
            // injects dependencies to the class.
            var container = DomainEvents.GetContainer();
            new ContainerConfiguration(container).Run();

            // fetch an existing account
            var accountRepo = container.GetInstance<IRepository>();
            Account account = accountRepo.GetById(100);

            // Do some cool stuff
            Console.WriteLine("The account name is {0}", account.Name);
            Console.WriteLine("");

            Console.ReadKey();

            Console.WriteLine("We're going to change the name to 'Tortoise'. Press a key.");
            Console.WriteLine("");

            Console.ReadKey();

            account.ChangeName("Tortoise");
        }
    }
}
