using System;
using System.Collections.Generic;
using System.Text;
using SampleDomainEvent.Interfaces;
using SampleDomainEvent.Events;

namespace SampleDomainEvent.EventHandlers
{
    public class EmailAccountOwnerAfterNameChanged : IHandle<NameChanged>
    {
        public void Handle(NameChanged args)
        {
            Console.WriteLine("[SEND EMAIL TO {0}] Your name has been changed to {1} from {2}",
                args.Account.EmailAddress,
                args.NewName,
                args.OldName);
        }
    }
}
