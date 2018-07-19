using OpenQA.Selenium.Firefox;

namespace SeleniumParallelTest
{
    public class Hooks : Base
    {
        public Hooks()
        {
            //Driver = new FirefoxDriver(@"C:\Users\A-JMontoya\source\repos\SeleniumParallelTest\SeleniumParallelTest\bin\Debug"); windows
            Driver = new FirefoxDriver("/Users/JuanCMontoya/Projects/test/SeleniumParallelTest/bin/Debug"); // mac
        }
    }
}
