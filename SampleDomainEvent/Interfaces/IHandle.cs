using System;
using System.Collections.Generic;
using System.Text;

namespace SampleDomainEvent.Interfaces
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
    }
}
