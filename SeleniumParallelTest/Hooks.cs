using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    public class Hooks : Base
    {
        public Hooks()
        {
            Driver = new FirefoxDriver();
        }
    }
}
