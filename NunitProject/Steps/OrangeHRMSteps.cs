using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;

namespace NunitProject.Steps
{
    [Binding]
    public class OrangeHRMSteps
    {
        IWebDriver driver;
        [Given(@"Launch chrome browser")]
        public void GivenLaunchChromeBrowser()
        {
            driver = new ChromeDriver(); 
        }
        
        [Given(@"Navigate to OrgangeHRM Page")]
        public void GivenNavigateToOrgangeHRMPage()
        {
            driver.Navigate().GoToUrl("https://www.orangehrm.com/");
            driver.Manage().Window.Maximize();
        }
        
        [When(@"I click Contactsales button")]
        public void WhenIClickContactsalesButton()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Contact Sales')]")).Click();
        }
        
        [When(@"Fill users infon HRM page")]
        public void WhenFillUsersInfonHRMPage()
        {
            driver.FindElement(By.CssSelector("#Form_submitForm_FirstName")).SendKeys("firstname");
            driver.FindElement(By.Id("Form_submitForm_LastName")).SendKeys("secondname");
            driver.FindElement(By.XPath("//input[@placeholder='Company Name']")).SendKeys("Company name");

            //Dropdown list 
            IWebElement numempselect = driver.FindElement(By.XPath("//select[@id='Form_submitForm_NoOfEmployees']"));
            SelectElement numberofemployees = new SelectElement(numempselect);
            numberofemployees.SelectByValue("16 - 20");
            //numberofemployees.SelectByText("16 - 20");
            //IList<IWebElement> elementcounts = numberofemployees.Options;
            //Console.WriteLine(elementcounts);
            driver.FindElement(By.XPath("//input[@id='Form_submitForm_JobTitle' and @name='JobTitle']")).SendKeys("JobTitle");
            driver.FindElement(By.Name("Contact")).SendKeys("97380179");
            driver.FindElement(By.Id("Form_submitForm_Email")).SendKeys("vanithaseeralangmail.com");
            IWebElement country=driver.FindElement(By.Id("Form_submitForm_Country"));
            SelectElement countryselect = new SelectElement(country);
            countryselect.SelectByText("Norway");
            driver.FindElement(By.Name("Comment")).SendKeys("This is Automation test of OrangeHRM websige using selenium C# with specflow BDD framework for differnt scenarios in chrome browser!! \n ***************Have a wonderful DAY***********");
            
            
           
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("window.scrollBy(0,800)");
            //driver.FindElement(By.Id("recaptcha-anchor")).Click();
            //driver.FindElement(By.XPath("//*[id='recaptcha-anchor' and @aria-checked='true'")).Click();
            //je.ExecuteScript("arguments[0].scrollIntoView(false);", s);

            driver.FindElement(By.XPath("//input[@id='Form_submitForm_action_request']")).Click();



        }
    }
}
