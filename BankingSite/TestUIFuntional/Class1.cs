using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUIFuntional
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void ShouldAcceptLoanApplication()
        {

            BrowserHost.Intance.Application.Browser.Navigate().GoToUrl(BrowserHost.RootUrl + @"LoanApplication/Apply");

            var firstNameBox = BrowserHost.Intance.Application.Browser.FindElement(By.Id("FirstName"));
            firstNameBox.SendKeys("Alb");

            var lastNameBox = BrowserHost.Intance.Application.Browser.FindElement(By.Id("LastName"));
            lastNameBox.SendKeys("Cast");

            var ageBox = BrowserHost.Intance.Application.Browser.FindElement(By.Id("Age"));
            ageBox.SendKeys("29");

            var incomeBox = BrowserHost.Intance.Application.Browser.FindElement(By.Id("Age"));
            incomeBox.SendKeys("9999999");

            DemoWaitHelper.Pause();

            var applyButton = BrowserHost.Intance.Application.Browser.FindElement(By.Id("Apply"));
            applyButton.Click();


            DemoWaitHelper.Pause(5000);

            var acceptedMessageText = BrowserHost.Intance.Application.Browser.FindElement(By.Id("acceptMessage"));

            Assert.That(acceptedMessageText.Text, Is.EqualTo("Congratulations fran - Your application was accepted!"));

            DemoWaitHelper.Pause(5000);


        }
    }
}
