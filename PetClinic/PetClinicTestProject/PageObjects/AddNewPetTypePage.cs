      // Generated by Selenium IDE
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
    public class AddNewPetTypePage: BasePage
    {
        public AddNewPetTypePage(IWebDriver driver) : base(driver) {}

        public IWebElement addPetButton => driver.FindElement(By.CssSelector(".addPet"));
        public IWebElement petTypeNameField => driver.FindElement(By.Id("name"));

        public void changeNameAndSave(IWebElement element, string text){
            element.Click();
            element.SendKeys(text);
            driver.FindElement(By.CssSelector(".saveType")).Click();
        }
    }
}