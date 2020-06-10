using BankingSite.Controllers;
using BankingSite.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TestStack.FluentMVCTesting;

namespace BankingSiteControllerTests.LoanAppControllerTests
{
    [TestFixture]
    public class LoanAppControllersTests
    {

        [Test]
        public void ShouldRenderDefaultView() {

            var fakeRepository = new Mock<IRepository>();
            var fakeLoanAppScorer = new Mock<ILoanApplicationScorer>();

            var sut = new LoanApplicationController(fakeRepository.Object, fakeLoanAppScorer.Object);

            sut.WithCallTo(x => x.Apply()).ShouldRenderDefaultView();
            
        }

        [Test]
        public void ShouldRedirectToAcceptedViewOnSuccessFulApp() {

            var fakeRepository = new Mock<IRepository>();
            var fakeLoanAppScorer = new Mock<ILoanApplicationScorer>();

            var sut = new LoanApplicationController(fakeRepository.Object, fakeLoanAppScorer.Object);

            var acceptedApp = new LoanApplication
            {
                IsAccepted = true
            };

            sut.WithCallTo(x => x.Apply(acceptedApp)).ShouldRedirectTo<int>(x => x.Accepted);


        }


        [Test]
        public void ShouldRedirectToDeclinedViewOnSuccessFulApp()
        {

            var fakeRepository = new Mock<IRepository>();
            var fakeLoanAppScorer = new Mock<ILoanApplicationScorer>();

            var sut = new LoanApplicationController(fakeRepository.Object, fakeLoanAppScorer.Object);

            var acceptedApp = new LoanApplication
            {
                IsAccepted = false
            };

            sut.WithCallTo(x => x.Apply(acceptedApp)).ShouldRedirectTo<int>(x => x.Declined);


        }


    }
}
