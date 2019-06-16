using System;
using System.Collections.Generic;
using System.Text;
using SampleDomainEvent.Entities;

namespace SampleDomainEvent.Interfaces
{
    public interface IRepository
    {
        Account GetById(int id);
        void UpdateAccount(Account account);
    }
}
