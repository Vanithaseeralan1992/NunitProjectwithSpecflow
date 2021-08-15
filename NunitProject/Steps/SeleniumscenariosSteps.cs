using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NunitProject.Steps
{
    [Binding]
    public class SeleniumscenariosSteps
    {
        IWebDriver driver = new ChromeDriver();
        [Given(@"Launch the chrome browsers and navigate to facebook\.com")]
        public void GivenLaunchTheChromeBrowsersAndNavigateToFacebook_Com()
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
        }
        [Given(@"Enter user name and Password and clicks enter")]
        public void GivenEnterUserNameAndPasswordAndClicksEnter()
        {
            driver.FindElement(By.Id("email")).SendKeys("vanitha1026135@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("Password" + Keys.Enter);

        }

        [When(@"I click friends button")]
          public void WhenIClickFriendsButton()
        {
            String vanithaSeeralan = driver.FindElement(By.XPath("//span[text()='Vanitha Seeralan']")).Text;
            Console.WriteLine(vanithaSeeralan);
            //Set<Cookie> allcookies = driver.Manage().getCookies();
            //driver.FindElement(By.XPath("//span[text(),Accept All]")).Click();
            //driver.FindElement(By.XPath("//*[@id='facebook']/body/div[4]/div[1]/div/div[2]/div/div/div/div/div[1]/div/div[3]/div/div[1]/div[1]/div/div[1]/div/span/span")).Click();
            //driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]")).Click();
            //driver.FindElement(By.XPath("//span[contains(text(),'Friends')]")).Click(); 
        }

        [Then(@"Count Lists of friends and prit Name in console")]
        public void ThenCountListsOfFriendsAndPritNameInConsole()
        {
            Thread.Sleep(10000);
            driver.Quit();
            
        }       
       
        [Then(@"User redirected to their account and search for (.*)")]
        public void ThenUserRedirectedToTheirAccountAndSearchFor(string searchname)
        {
            searchname = "seeralan radha";
            driver.FindElement(By.Name("global_typeahead")).SendKeys(searchname);
        }
        [Given(@"Navigate to create account page")]
        public void GivenNavigateToCreateAccountPage()
        {
            driver.FindElement(By.XPath("//*[@id='u_0_p_Nf']")).Click();
            driver.FindElement(By.XPath("//*[@id='u_0_2_dG' and @class='_42ft _4jy0 _6lti _4jy6 _4jy2 selected _51sy']")).Click();
        }

        [Given(@"Enter firstname and lastname, emailaddress, password, dob, gender")]
        public void GivenEnterFirstnameAndLastnameEmailaddressPasswordDobGender()
        {
            driver.FindElement(By.Name("firstname")).SendKeys("firstname");
            driver.FindElement(By.Name("")).SendKeys("");
        }

        [When(@"I click signup button")]
        public void WhenIClickSignupButton()
        {
            
        }

        [Then(@"Navigate to facebookpage and quit browser")]
        public void ThenNavigateToFacebookpageAndQuitBrowser()
        {
            
        }

        [Given(@"Launch the chrome browsers and navigate to executeautomation\.com")]
        public void GivenLaunchTheChromeBrowsersAndNavigateToExecuteautomation_Com()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("loginLink")).Click();
        }

        [Given(@"Enter username and Password of executeautomation")]
        public void GivenEnterUsernameAndPasswordOfExecuteautomation()
        {
            driver.FindElement(By.Id("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("password");
        }

        [When(@"I click login button of execute automation page")]
        public void WhenIClickLoginButtonOfExecuteAutomationPage()
        {
            driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();

        }


        [Then(@"User redirected logged in page and close it")]
        public void ThenUserRedirectedLoggedInPageAndCloseIt()
        {
            Thread.Sleep(10000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(10);
            driver.Close();
            driver.Quit();
        }



    }
}
