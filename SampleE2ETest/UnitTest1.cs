using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace SampleE2ETest
{
    public class Tests
    {
        public IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
        }

        [Test]
        public void Test_selenium_Form()
        {
            driver.Navigate().GoToUrl(" https://www.lambdatest.com/selenium-playground/simple-form-demo");
            driver.FindElement(By.Id("user-message")).SendKeys("Hello Selenium");
            driver.FindElement(By.Id("showInput")).Click();

            var messagelabel = driver.FindElement(By.Id("message")).Text;

            Assert.IsTrue(driver.FindElement(By.Id("message")).Text.Equals("Hello Selenium"), "The expected message was not displayed");

            Assert.That(messagelabel, Is.EqualTo("Hello Selenium"));
        }
        [TearDown]
        public void TearDown()
        {
            if(driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}