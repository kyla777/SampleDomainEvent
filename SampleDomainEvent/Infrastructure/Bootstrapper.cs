using System;
using System.Collections.Generic;
using System.Text;
using SampleDomainEvent.Interfaces;
using StructureMap;
using SampleDomainEvent.Events;
using SampleDomainEvent.EventHandlers;
using SampleDomainEvent.Repositories;

namespace SampleDomainEvent.Infrastructure
{
    public class Bootstrapper
    {
        public  readonly Container _container;

        public Bootstrapper(Container container)
        {
            _container = container;
        }

        public void Run()
        {
            _container.Configure(configuration =>
            {
                configuration.For<IHandle<NameChanged>>().Use<EmailAccountOwnerAfterNameChanged>();

                configuration.For<IRepository>().Use<AccountRepository>();
            });
        }
    }
}
