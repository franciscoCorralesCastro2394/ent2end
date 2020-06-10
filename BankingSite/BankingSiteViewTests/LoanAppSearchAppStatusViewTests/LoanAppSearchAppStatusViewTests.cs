using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSite.Views;
using BankingSite.Models;
using HtmlAgilityPack;
using RazorGenerator.Testing;

namespace BankingSiteViewTests.LoanAppSearchAppStatusViewTests
{
    [TestFixture]
   public  class LoanAppSearchAppStatusViewTests
    {

        [Test]
        public void ShoulRenderAcceptdMessage() {

            var sut = new BankingSite.Views.LoanApplicationSearch.ApplicationStatus();

            var model = new LoanApplication { IsAccepted = true };

            HtmlDocument html = sut.RenderAsHtml(model);


            var message = html.GetElementbyId("status").InnerText;

            Assert.That(message, Contains.Substring("Yay! Accepted!"));
        }

    }
}
