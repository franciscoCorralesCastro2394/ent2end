using BankingSite.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.IntegrationTests.RepositoryTests
{
    [TestFixture]
    public class RepositoryTests
    {

        [Test]
        public void ShouldPopulateIDOnCreateLoanApplication() {

            var sut = new Repository();

            var application = new LoanApplication
            {
                Age = 33,
                AnnualIncome = 12345.67m,
                FirstName = "Alb",
                LastName = "Cast"
            };

            sut.Create(application);

            Assert.That(application.ID, Is.Not.EqualTo(0));

        }

    }
}
