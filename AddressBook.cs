using System;
using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> contactBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            contactBook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            try
            {
                Contact returnContact = contactBook[email];
                return returnContact;
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }
    }
}