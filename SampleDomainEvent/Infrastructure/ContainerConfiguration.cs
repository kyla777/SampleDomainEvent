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
    public class ContainerConfiguration
    {
        public readonly Container _container;

        public ContainerConfiguration(Container container)
        {
            _container = container;
        }

        public void Run()
        {
            _container.Configure(set =>
            {
                set.For<IHandle<NameChanged>>().Use<EmailAccountOwnerAfterNameChanged>();

                set.For<IRepository>().Use<AccountRepository>();
            });
        }
    }
}
