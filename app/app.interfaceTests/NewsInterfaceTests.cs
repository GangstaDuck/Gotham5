using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace app.interfaceTests
{
    public class NewsInterfaceTests
    {
        private IWebDriver driver;

        //private const string FIREFOX_EXE_PATH = "C:\Program Files\Mozilla Firefox\firefox.exe";
        private const string APP_NEWS_URL = "https://localhost:44341/Home/News";
        private const string ADD_NEWS_URL = "https://localhost:44341/Home/News/Add";

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver("./");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Check_AddNews_ShouldRedirectToChangeAddNewsPage()
        {
            driver.Navigate().GoToUrl(APP_NEWS_URL);

            //Click Add news
            var adddNewsLink = driver.FindElement(By.PartialLinkText("Ajouter"));
            adddNewsLink.Click();

            Assert.AreEqual(ADD_NEWS_URL, adddNewsLink);
            driver.Quit();
        }

        [Test]
        public void Check_DeleteNews_ShouldRedirectToChangeDeleteNewsPage()
        {
            driver.Navigate().GoToUrl(APP_NEWS_URL);

            //Click Add news
            var deleteNewsLink = driver.FindElement(By.PartialLinkText("Supprimer"));
            deleteNewsLink.Click();

            Assert.AreEqual(ADD_NEWS_URL, deleteNewsLink);
            driver.Quit();
        }

        [Test]
        public void Check_EditNews_ShouldRedirectToChangeEditNewsPage()
        {
            driver.Navigate().GoToUrl(APP_NEWS_URL);

            //Click Add news
            var EditNewsLink = driver.FindElement(By.PartialLinkText("Modifier"));
            EditNewsLink.Click();

            Assert.AreEqual(ADD_NEWS_URL, EditNewsLink);
            driver.Quit();
        }
    }
}
