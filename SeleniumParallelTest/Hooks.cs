using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks : Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
            //Driver = new FirefoxDriver(@"C:\Users\jcmon\source\repos\SeleniumParallelTest\SeleniumParallelTest\bin\Debug"); //windows
            //Driver = new FirefoxDriver("/Users/JuanCMontoya/Projects/test/SeleniumParallelTest/bin/Debug"); // mac
        }

        [SetUp]
        public void InitializeTest()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowserType.Firefox)
                Driver = new FirefoxDriver();
        }
    }
}
