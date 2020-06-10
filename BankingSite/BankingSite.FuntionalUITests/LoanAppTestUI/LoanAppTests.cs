using BankingSite.FuntionalUITests.helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestStack.Seleno.Configuration;

namespace BankingSite.FuntionalUITests.LoanAppTestUI
{
    [NUnit.Framework.TestFixture]
   public  class LoanAppTests
    {
        public static readonly SelenoHost Instance = new SelenoHost();

        [Test]
        public void ShouldAcceptLoanApplication()
        {

            //BrowserHost.Instance.Application.Browser.Navigate().GoToUrl(BrowserHost.RootUrl + @"LoanApplication/Apply");

            //var instance = new SelenoHost();

            //instance.Run("BankingSite", 15445, w => w.WithRemoteWebDriver(() => new ChromeDriver()));
            //DemoWaitHelper.Pause();


            //var firstNameBox = instance.Application.Browser.FindElement(By.Id("FirstName"));
            //firstNameBox.SendKeys("Alb");

            //var lastNameBox = instance.Application.Browser.FindElement(By.Id("LastName"));
            //lastNameBox.SendKeys("Cast");

            //var ageBox = instance.Application.Browser.FindElement(By.Id("Age"));
            //ageBox.SendKeys("29");

            //var incomeBox = instance.Application.Browser.FindElement(By.Id("Age"));
            //incomeBox.SendKeys("9999999");

            //DemoWaitHelper.Pause();

            //var applyButton = instance.Application.Browser.FindElement(By.Id("Apply"));
            //applyButton.Click();


            //DemoWaitHelper.Pause(5000);

            //var acceptedMessageText = instance.Application.Browser.FindElement(By.Id("acceptMessage"));

            //Assert.That(acceptedMessageText.Text, Is.EqualTo("Congratulations fran - Your application was accepted!"));

            //DemoWaitHelper.Pause(5000);


        }


        [Test]
        public void ShouldDeclineLoanApplication()
        {

            //BrowserHost.Instance.Application.Browser.Navigate().GoToUrl(BrowserHost.RootUrl + @"LoanApplication/Apply");

            //var firstNameBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("FirstName"));
            //firstNameBox.SendKeys("Alb");

            //var lastNameBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("LastName"));
            //lastNameBox.SendKeys("Cast");

            //var ageBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("Age"));
            //ageBox.SendKeys("16");

            //var incomeBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("Age"));
            //incomeBox.SendKeys("9999999");

            //DemoWaitHelper.Pause();

            //var applyButton = BrowserHost.Instance.Application.Browser.FindElement(By.Id("Apply"));
            //applyButton.Click();


            //DemoWaitHelper.Pause(5000);

            //var acceptedMessageText = BrowserHost.Instance.Application.Browser.FindElement(By.Id("declineMessage"));

            //Assert.That(acceptedMessageText.Text, Is.EqualTo("Sorry Alb - We are unable to offer you a loan at this time."));

            //DemoWaitHelper.Pause(5000);


        }


    }
}
