using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrmModels;
using CrmDatabaseManagement;

namespace CrmRepository
{
    public class CompanyRepository : IRepository<Company>
    {
        CrmEntities entities;

        public CompanyRepository()
        {
            entities = new CrmEntities();
        }

        public List<Company> GetAll()
        {
            return entities.Companies.ToList();
        }

        public Company Find(int id)
        {
            Company company;

            company = entities.Companies.Find(id);
            return company;
        }

        public void Add(Company company)
        {
            entities.Companies.Add(company);
            entities.SaveChanges();
        }

        public void Update(Company company, int id)
        {
            Company companyToUpdate = entities.Companies.Find(id);

            companyToUpdate.Name = company.Name;
            companyToUpdate.Country = company.Country;
            companyToUpdate.City = company.City;

            entities.SaveChanges();
        }

        public void Delete(int id)
        {
            Company companyToRemove = entities.Companies.Find(id);

            entities.Companies.Remove(companyToRemove);

            entities.SaveChanges();
        }
    }
}
