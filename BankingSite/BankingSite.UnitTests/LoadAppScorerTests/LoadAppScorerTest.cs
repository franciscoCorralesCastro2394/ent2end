using BankingSite.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSite.UnitTests.LoadAppScorerTests
{
    [TestFixture]
    public class LoadAppScorerTest
    {
        [Test]
        public void ShouldDeclineWhenNotTooYoungAndWealthyButPoorCredit_Clasical() {

            var sut = new LoanApplicationScorer(new CreditHistoryChecker());

            var application = new LoanApplication
            {
                Age = 22,
                AnnualIncome = 1000000.01m,
                FirstName = "Sarah",
                LastName = "Smith"
            };

            sut.ScoreApplication(application);

            Assert.That(application.IsAccepted, Is.False);

        
        }



        [Test]
        public void ShouldDeclineWhenNotTooYoungAndWealthyButPoorCredit()
        {

            var fakeCreditHistoryChecker = new Mock<ICreditHistoryChecker>();

            fakeCreditHistoryChecker.Setup(x => x.CheckCreditHistory(It.IsAny<string>(), It.IsAny<string>())).Returns(false);

            var sut = new LoanApplicationScorer(fakeCreditHistoryChecker.Object);

            var application = new LoanApplication
            {
                Age = 22,
                AnnualIncome = 1000000.01m,
            };

            sut.ScoreApplication(application);

            Assert.That(application.IsAccepted, Is.False);


        }

    }
}
