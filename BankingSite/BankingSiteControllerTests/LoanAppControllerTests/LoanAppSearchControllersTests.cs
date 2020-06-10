using BankingSite.Controllers;
using BankingSite.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestStack.FluentMVCTesting;

namespace BankingSiteControllerTests.LoanAppControllerTests
{
    [TestFixture]
    public class LoanAppSearchControllersTests
    {
        [Test]
        public void ShouldReturn404StatusWhenLaonIDNotExists() { 
            
            var fakeRepository = new Mock<IRepository>();

            var sut = new LoanApplicationSearchController(fakeRepository.Object);

            sut.WithCallTo(x => x.ApplicationStatus(99)).ShouldGiveHttpStatus(HttpStatusCode.NotFound);
            
        }


        [Test]
        public void ShouldRenderAppWhenIdExists()
        {

            var fakeRepository = new Mock<IRepository>();

            fakeRepository.Setup(x => x.Find(99)).Returns(new LoanApplication { FirstName = "Alb" });

            var sut = new LoanApplicationSearchController(fakeRepository.Object);

            sut.WithCallTo(x => x.ApplicationStatus(99)).
                ShouldRenderDefaultView().WithModel<LoanApplication>(x => x.FirstName == "Alb");


        }



        }
}
