using System;
using StructureMap;
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
            // bootstrap the application
            var container = DomainEvents.GetContainer();
            new Bootstrapper(container).Run();

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
