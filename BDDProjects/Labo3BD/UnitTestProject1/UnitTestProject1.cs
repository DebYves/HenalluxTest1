using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labo3BD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestProject1
    {
        public CompanyContext GetContext()
        {

            return new CompanyContext();
        }

        [TestInitialize]
        public void setup()
        {
            Database.SetInitializer(new DbInitializer());
            using (CompanyContext context = GetContext())
            {
                context.Database.Initialize(true);
            }
        }
        /*
        [TestMethod]
        public void InsertionFonctionnelle()
        {
            using (var context = GetContext())
            {
                Assert.AreEqual(1,context.Customers.ToList().Count);
            }
        }*/

        [TestMethod]
        [ExpectedException(typeof(DbUpdateConcurrencyException))]
        public void MegaTest()
        {
            using (CompanyContext context1 = GetContext())
            {
                using (CompanyContext context2 = GetContext())
                {
                    var client1 = context1.Customers.First();
                    var client2 = context2.Customers.First();

                    client1.AccountBalance += 1000;
                    context1.SaveChanges();

                    client2.AccountBalance += 2000;
                    context2.SaveChanges();
                }
            }
        }
    }
}
