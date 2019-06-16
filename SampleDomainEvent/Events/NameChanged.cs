using System;
using System.Collections.Generic;
using System.Text;
using SampleDomainEvent.Entities;
using SampleDomainEvent.Interfaces;

namespace SampleDomainEvent.Events
{
    public class NameChanged : IDomainEvent
    {
        public Account Account;
        public string NewName;
        public string OldName;

        public NameChanged(Account account, string oldName, string newName)
        {
            Account = account;
            OldName = oldName;
            NewName = newName;
        }
    }
}
