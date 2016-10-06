using System;
using System.Data.Entity;
using Labo3BD;

//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    public class DbInitializer:DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                Name = "Albert Dupont",
                AddressLine1 = "Rue des cerisiers, 16",
                City = "Arlon",
                Country = "Belgique",
                EMail = "info@me.com",
                Id = 3,
                Remark = "bfzkfzkfz",
                PostCode = "6700"
            };
            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
