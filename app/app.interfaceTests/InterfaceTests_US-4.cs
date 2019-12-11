using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace app.interfaceTests
{
    public class CapsulesInterfaceTests
    {
        private IWebDriver driver;

        //private const string FIREFOX_EXE_PATH = "C:\Program Files\Mozilla Firefox\firefox.exe";
        private const string APP_CAPSULES_URL = "https://localhost:44341/Home/Capsules";
        private const string ADD_CAPSULES_URL = "https://localhost:44341/Home/Capsles/Create";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver("./");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Check_AddCapsules_ShouldRedirectToChangeAddCapsulesPage()
        {
            driver.Navigate().GoToUrl(APP_CAPSULES_URL);

            //Click Add capsules
            var adddCapsulesLink = driver.FindElement(By.PartialLinkText("Créer"));
            adddCapsulesLink.Click();

            Assert.AreEqual(ADD_CAPSULES_URL, adddCapsulesLink);
            driver.Quit();
        }

        [Test]
        public void Check_DeleteCapsules_ShouldRedirectToChangeDeleteCapsulesPage()
        {
            driver.Navigate().GoToUrl(APP_CAPSULES_URL);

            //Click Add capsules
            var deleteCapsulesLink = driver.FindElement(By.PartialLinkText("Delete"));
            deleteCapsulesLink.Click();

            Assert.AreEqual(ADD_CAPSULES_URL, deleteCapsulesLink);
            driver.Quit();
        }

        [Test]
        public void Check_EditCapsules_ShouldRedirectToChangeEditCapsulesPage()
        {
            driver.Navigate().GoToUrl(APP_CAPSULES_URL);

            //Click Add capsules
            var EditCapsulesLink = driver.FindElement(By.PartialLinkText("Edit"));
            EditCapsulesLink.Click();

            Assert.AreEqual(ADD_CAPSULES_URL, EditCapsulesLink);
            driver.Quit();
        }
    }
}