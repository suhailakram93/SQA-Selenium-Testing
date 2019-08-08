using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class EmptyAll
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheEmptyAllTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sell car here..'])[1]/following::form[1]")).Click();
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorName")).Text);
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorAdd")).Text);
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorphone")).Text);
            Assert.AreEqual("Please enter valid email address.", driver.FindElement(By.Id("errorEmail")).Text);
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorveh")).Text);
        }

        [Test]
        public void TheEmptyNameTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("20-weber");
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("London");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("519-478-8877");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("rendon@gmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("pontiac G6 2010");
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorName")).Text);
        }

        [Test]
        public void TheEmptyAddressTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Rahul K");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("741-852-7474");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("rahul@gmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("Audi A6 2012");
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorAdd")).Text);
        }

        [Test]
        public void TheEmptyCityTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Car Details'])[1]/following::div[1]")).Click();
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Suhail Md");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("140 weber north");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("519-616-0147");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("suhail");
            driver.FindElement(By.Id("email")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("email")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("suhailakram124@gmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("BM");
            driver.FindElement(By.Id("vehicle")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("BMX aa 2019");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("BMX 2");
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("BMX 2series 2019");
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorCity")).Text);
        }

        [Test]
        public void ThePhoneEmptyTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Ricky Maz");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("874-weber");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("ki");
            driver.FindElement(By.Id("city")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("kitchener");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("rick");
            driver.FindElement(By.Id("email")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("ricky@gmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("porsche 718Boxster 2018");
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorphone")).Text);
        }

        [Test]
        public void TheEmailEmptyTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("ha");
            driver.FindElement(By.Id("cname")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Hayden rick");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("289-rassel street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("Waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("519-789-4785");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("Audi A6 2012");
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please enter valid email address.", driver.FindElement(By.Id("errorEmail")).Text);
        }

        [Test]
        public void TheEmptyVehicleTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("chaminda vass");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("85-hekery street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("45");
            driver.FindElement(By.Id("phone")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("457-789-7744");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("cha");
            driver.FindElement(By.Id("email")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("chaminda@hotmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("reg")).Click();
            Assert.AreEqual("Please fill this field", driver.FindElement(By.Id("errorveh")).Text);
        }

        [Test]
        public void TheSucess1Test()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Rick Zahiri");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("25-hazel street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("waterloo");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("787-858-4455");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("rickzahiri@hotmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("au");
            driver.FindElement(By.Id("vehicle")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("Audi A6 2012");
            driver.FindElement(By.Id("reg")).Click();
            driver.FindElement(By.Id("carInformation")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Audi A6 2012'])[25]/following::a[5]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Click();
            Assert.AreEqual("2012 Audi A6 ratings and reviews", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Text);
        }

        [Test]
        public void TheSecondTestSucessTest()
        {
            driver.Navigate().GoToUrl("http://localhost/Assignment_4/mainAssignment4.html");
            driver.FindElement(By.Id("cname")).Click();
            driver.FindElement(By.Id("cname")).Clear();
            driver.FindElement(By.Id("cname")).SendKeys("Hayden rick");
            driver.FindElement(By.Id("address")).Click();
            driver.FindElement(By.Id("address")).Clear();
            driver.FindElement(By.Id("address")).SendKeys("14-whistle street");
            driver.FindElement(By.Id("city")).Click();
            driver.FindElement(By.Id("city")).Clear();
            driver.FindElement(By.Id("city")).SendKeys("cambridge");
            driver.FindElement(By.Id("phone")).Click();
            driver.FindElement(By.Id("phone")).Clear();
            driver.FindElement(By.Id("phone")).SendKeys("519-789-4785");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("hayden@gmail.com");
            driver.FindElement(By.Id("vehicle")).Click();
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("A");
            driver.FindElement(By.Id("vehicle")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("vehicle")).Clear();
            driver.FindElement(By.Id("vehicle")).SendKeys("Audi A6 2012");
            driver.FindElement(By.Id("reg")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Audi A6 2012'])[29]/following::a[1]")).Click();
            // ERROR: Caught exception [ERROR: Unsupported command [selectWindow | win_ser_1 | ]]
            Assert.AreEqual("2012 AUDI A6 RATINGS AND REVIEWS", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Select Trim'])[1]/following::h1[1]")).Text);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
