using System;
using SampleDomainEvent.Events;

namespace SampleDomainEvent.Entities
{
    public class Account
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public string EmailAddress { get; set; }

        public void ChangeName(string newName)
        {
            Console.WriteLine("Changing name...");
            Console.WriteLine("");

            string oldName = Name;
            Name = newName;
            
            DomainEvents.Raise<NameChanged>(new NameChanged(this, oldName, newName));
        }
    }
}
