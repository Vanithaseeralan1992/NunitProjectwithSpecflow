using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowproject.FeaturesFiles
{
    [Binding]
    public class SearchtestingSteps
    {
        public IWebDriver driver;
        [Given(@"Launch Chrome browser")]
        public void GivenLaunchChromeBrowser()
        {
            //Launch Browser
             driver = new ChromeDriver();
            // Naviate to URL https://www.codeproject.com
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
            
                     
           
            

            //Click on Search Button
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();

            driver.Quit();
        }
        
        [Given(@"Navidage to code\.com project")]
        public void GivenNavidageToCode_ComProject()
        {
            driver.Navigate().GoToUrl("https://www.codeproject.com");
            
        }
        
        [When(@"Click on SEarch our Articles")]
        public void WhenClickOnSEarchOurArticles()
        {
            //Click on search our Articles
            driver.FindElement(By.XPath("//*[@id='ctl00_ContentPane']/div[1]/div/table[1]/tbody/tr/td[3]/a/img")).Click();
            
        }
        
        [When(@"Enter Testing")]
        public void WhenEnterTesting()
        {
            //Enter Testing 
            driver.FindElement(By.Id("ctl00_MC_Query")).SendKeys("Testing");
        }
        
        [When(@"Click on Search Button")]
        public void WhenClickOnSearchButton()
        {
            //Click on Search Button
            driver.FindElement(By.Id("ctl00_MC_Go")).Click();
        }
        
        [Then(@"Result should be visible and Browser should close")]
        public void ThenResultShouldBeVisibleAndBrowserShouldClose()
        {
            driver.Quit();
        }
    }
}
