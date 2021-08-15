using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace NunitProject.Steps
{
    [Binding]
    public class GmailfeatureSteps
    {
        IWebDriver driverfox;
        [Given(@"Launch firefox browser")]
        public void GivenLaunchFirefoxBrowser()
        {
            driverfox = new FirefoxDriver();
            
        }
        
        [Given(@"Navigate to Gmail page")]
        public void GivenNavigateToGmailPage()
        {
            driverfox.Navigate().GoToUrl("https://www.google.com/intl/no/gmail/about/");
        }
        
        [When(@"I click login")]
        public void WhenIClickLogin()
        {
            driverfox.FindElement(By.LinkText("Logg på")).Click();
        }
        
        [When(@"Enter username and password")]
        public void WhenEnterUsernameAndPassword()
        {
            //driverfox.FindElement(By.XPath("//input[@id='identifierId' and @autocomplete='username']")).SendKeys("vanithaseeralan@gmail.com");
            driverfox.FindElement(By.CssSelector("input[id='identifierId']")).SendKeys("Vanithaseeralan@gmail.com");

        }
        
        [Then(@"User is loggedin")]
        public void ThenUserIsLoggedin()
        {
            driverfox.Quit();
        }
    }
}
