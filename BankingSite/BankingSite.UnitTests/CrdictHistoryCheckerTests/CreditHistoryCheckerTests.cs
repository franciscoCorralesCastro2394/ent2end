using BankingSite.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.UnitTests.CrdictHistoryCheckerTests
{
    [TestFixture]
    public class CreditHistoryCheckerTests
    {

        [Test]
        public void ShouldRecognizePeopleWithBadCredit() {

            var sut = new CreditHistoryChecker();

            var isCreditWorthy = sut.CheckCreditHistory("Sarah","Smith");

            Assert.That(isCreditWorthy, Is.False);
        
        
        }


        [Test]
        public void ShouldRecognizePeopleWithOKCredit()
        {

            var sut = new CreditHistoryChecker();

            var isCreditWorthy = sut.CheckCreditHistory("Francisco", "Corrales");

            Assert.That(isCreditWorthy, Is.False);


        }

    }
}
