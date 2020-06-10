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

namespace BankingSiteViewTests.HomeIndexViewTests
{
    [TestFixture]
    public class HomeIndexViewTests
    {

        [Test]
        public void ShouldRenderLoanInterestRate() {

            var sut = new BankingSite.Views.Home.Index();

            var model = new InterestRates
            {

                LoanRate = 22.22m

            };


            HtmlDocument html = sut.RenderAsHtml(model);

            var renderedLoanRate = html.GetElementbyId("loanRate").InnerText;

            Assert.That(renderedLoanRate, Is.EqualTo("22.22"));

        }


        [Test]
        public void ShouldRenderMainMessage()
        {

            var sut = new BankingSite.Views.Home.Index();

            sut.ViewBag.Message = "Hello Grupo Babel";

            HtmlDocument html = sut.RenderAsHtml(new InterestRates());

            var actulMessage = html.GetElementbyId("mainMessage").InnerText;


            Assert.That(actulMessage, Is.EqualTo("Hello Grupo Babel"));


        }


    }
    }
