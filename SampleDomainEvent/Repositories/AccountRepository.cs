using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SampleDomainEvent.Entities;
using SampleDomainEvent.Interfaces;

namespace SampleDomainEvent.Repositories
{
    public class AccountRepository : IRepository
    {
        private readonly List<Account> accounts = new List<Account>()
        {
            new Account {
                Id = 100,
                Name = "Turtle",
                EmailAddress = "sample@turtle.com"
            }
        };
        
        public Account GetById(int id)
        {
            var result = accounts.Find(user => user.Id == id);

            if(result.Id != 0)
            {
                return result;
            }

            return null;
        }

        public void UpdateAccount(Account account)
        {
            foreach (Account a in accounts)
            {
                if(a.Id == account.Id)
                {
                    a.Name = account.Name;
                    a.EmailAddress = account.EmailAddress;
                }
            }
        }
    }
}
