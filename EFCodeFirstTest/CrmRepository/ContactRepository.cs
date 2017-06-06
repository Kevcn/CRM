using CrmModels;
using CrmDatabaseManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmRepository
{
    public class ContactRepository : IRepository<Contact>
    {
        CrmEntities entities;

        public ContactRepository(){

            entities = new CrmEntities();

        }

        public List<Contact> GetAll()
        {
            return entities.Contacts.ToList();
        }

        public Contact Find(int id)
        {
            Contact contact;

            contact = entities.Contacts.Find(id);
            return contact;
        }

        public void Add(Contact contact)
        {
            entities.Contacts.Add(contact);
            entities.SaveChanges();
        }

        public void Update(Contact contact, int id)
        {
            Contact contactToUpdate = entities.Contacts.Find(id);

            contactToUpdate.Name = contact.Name;
            contactToUpdate.Company = contact.Company;
            contactToUpdate.Phone = contact.Phone;
            contactToUpdate.Position = contact.Position;
            contactToUpdate.Email = contact.Email;
            contactToUpdate.Favorite = contact.Favorite;

            entities.SaveChanges();
        }

        public void Delete(int id)
        {
            Contact contactToRemove = entities.Contacts.Find(id);
            entities.Contacts.Remove(contactToRemove);

            entities.SaveChanges();
        }
    }
}
