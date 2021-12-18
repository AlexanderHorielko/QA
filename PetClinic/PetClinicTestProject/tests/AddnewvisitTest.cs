using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
using NUnit.Allure.Attributes;

namespace PetClinicTestProject
{
    [TestFixture]
    [Parallelizable]
    public class AddnewvisitTest : Hooks
    {
        public AddnewvisitTest() : base(BrowserType.Chrome) {}
        [Test]
        [AllureSuite("Check add new visit functionality")]
        public void addnewvisit()
        {
            pages.Navigation.OwnerTab.Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) span:nth-child(2)")).Click();
            Helpers.WaitUntilVisible(driver, By.LinkText("Ivan Ivanov"), 20);
            driver.FindElement(By.LinkText("Ivan Ivanov")).Click();
            driver.FindElement(By.CssSelector(".addNewVisit")).Click();
            pages.AddNewVisit.chooseDate(Visits.Visits[0].Date);
            pages.AddNewVisit.descriptionField.Click();
            pages.AddNewVisit.descriptionField.Clear();
            var description = Visits.Visits[0].Description;
            pages.AddNewVisit.descriptionField.SendKeys(description);
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            driver.FindElement(By.CssSelector(".visitDescription")).Click();
            Assert.That(driver.FindElement(By.CssSelector("tr:nth-last-child(1) > .visitDescription")).Text, Is.EqualTo(description));
        }
    }
}