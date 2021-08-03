using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public IWebDriver driver = new ChromeDriver();
        [Test]
        public void ExecuteAutomatioTest()
        {
            //IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            driver.FindElement(By.Id("loginLink")).Click();
            driver.FindElement(By.Id("UserName")).SendKeys("admin");
            driver.FindElement(By.Name("Password")).SendKeys("password");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Submit();
            driver.Close();
            driver.Quit();
        }
        [Test]
        public void BanIDonMobile()
        {
            driver.Navigate().GoToUrl("https://www.altinn.no/");
            driver.FindElement(By.XPath("//button[@type='button' and @class='a-btn a-btn-border']")).Click();
            driver.FindElement(By.Id("BankIDMobil")).Click();
            driver.FindElement(By.Id("idporten.input.CONTACTINFO_MOBILE")).SendKeys("MobileNumber");
            driver.FindElement(By.Id("idporten.input.BIRTHDATE")).SendKeys("DOB");
            driver.FindElement(By.Id("nextbtn")).Click();

            //driver.FindElement(By.ClassName("ai ai-private-circle-big a-personSwitcher-icon a-js-onboardingTarget-1")).Click();

        }
    }
}
