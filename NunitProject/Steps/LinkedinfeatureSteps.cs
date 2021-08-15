using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace NunitProject.Steps
{
    [Binding]
    public class LinkedinfeatureSteps
    {
        IWebDriver driverfox;
        [Given(@"Launch Firefox browser")]
        public void GivenLaunchFirefoxBrowser()
        {
            driverfox = new FirefoxDriver();
        }

        [Given(@"Navigate to LinkedIn page")]
        public void GivenNavigateToLinkedInPage()
        {
            driverfox.Navigate().GoToUrl("https://www.linkedin.com");
         
        }


        [Given(@"Enter username and password")]
        public void GivenEnterUsernameAndPassword()
        {
            driverfox.FindElement(By.LinkText("Logg på")).Click();
            System.Threading.Thread.Sleep(5000);
            driverfox.FindElement(By.Id("username")).SendKeys("vanithaseeralan@yahoo.com");
            driverfox.FindElement(By.Id("password")).SendKeys("Password");

        }

        [When(@"I click to login")]
        public void WhenIClickToLogin()
        {
            driverfox.FindElement(By.XPath("//button[@aria-label='Logg på']")).Click();
        }

        [Then(@"User is logged in and quite browser")]
        public void ThenUserIsLoggedInAndQuiteBrowser()
        {
            driverfox.Quit();
        }
        [When(@"I click Bli med på link")]
        public void WhenIClickBliMedPaLink()
        {
            driverfox.FindElement(By.LinkText("Bli med nå")).Click();
            //driverfox.FindElement(By.XPath("//button[@id='join-form-submit' and @type='submit']")).Click();
            //driverfox.FindElement(By.XPath("//*[@id='join - form - submit']")).Click();
            //driverfox.FindElement(By.XPath("//*[@value='Godta og bli med' and @text()='Godta og bli med']")).Click();
            driverfox.FindElement(By.XPath("//span[@class='join-form__form-body-agreement']/button")).Click();
        }

    }

    }
