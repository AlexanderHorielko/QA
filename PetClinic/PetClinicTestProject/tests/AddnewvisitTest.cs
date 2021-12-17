using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;
namespace PetClinicTestProject
{
    public class AddnewvisitTest : TestBase
    {
        [Test]
        public void addnewvisit()
        {
            driver.FindElement(By.CssSelector(".ownerTab")).Click();
            driver.FindElement(By.CssSelector(".open li:nth-child(1) span:nth-child(2)")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Ivan Ivanov")));
            driver.FindElement(By.LinkText("Ivan Ivanov")).Click();
            driver.FindElement(By.CssSelector(".addNewVisit")).Click();
            AddNewVisitPage.chooseDate();
            AddNewVisitPage.descriptionField.Click();
            AddNewVisitPage.descriptionField.Clear();
            AddNewVisitPage.descriptionField.SendKeys("new visit");
            driver.FindElement(By.CssSelector(".addVisit")).Click();
            driver.FindElement(By.CssSelector(".visitDescription")).Click();
            Assert.That(driver.FindElement(By.CssSelector(".visitDescription")).Text, Is.EqualTo("new visit"));
        }
    }
}