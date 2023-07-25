using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    internal class Contact
    {
        public string FirstName{get; set;}
        public string LastName { get; set;}
        public int Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    class Add : Contact
    {
        LinkedList<Contact> contacts = new LinkedList<Contact>();

        public void AddContact(Contact contact)
        {
            contacts.AddLast(contact);
        }
    }
}
