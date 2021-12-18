using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using OpenQA.Selenium.Support.UI;

public static class Helpers {
    public static void ClearAndType(IWebElement element, string text){
        element.Clear();
        element.SendKeys(text);
    }

    public static void ScrollToBottom(IWebDriver driver, string selector){
        var element = driver.FindElement(By.CssSelector(selector));
        Actions builder = new Actions(driver);
        builder.MoveToElement(element, 0, 0).Perform();
    }

    public static void WaitUntilVisible(IWebDriver driver, By element, int seconds){
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
        wait.Until(ExpectedConditions.ElementIsVisible(element));
    }
}