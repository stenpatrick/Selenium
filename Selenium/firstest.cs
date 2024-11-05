using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace Selenium
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            TestClick(); 
            TestDoubleClick(); 
            TestHiddenLayers();
            TestClientDelay();
            TestLoadDelays();
            TestUpload();
            TestHidingButton();

        }

        private static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/click";

            IWebElement element = driver.FindElement(By.Id("badButton"));
            element.Click();
        }

        private static void TestDoubleClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/mouseover";

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.ClassName("text-primary"));
            actions.DoubleClick(element).Perform();

        }

        private static void TestHiddenLayers()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/hiddenlayers";

            IWebElement element = driver.FindElement(By.Id("greenButton"));
            element.Click();
        }

        private static void TestClientDelay()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/clientdelay";

            IWebElement element = driver.FindElement(By.Id("ajaxButton"));
            element.Click();
            Thread.Sleep(15000);
            IWebElement p = driver.FindElement(By.ClassName("bg-success"));
            p.Click();
        }

        private static void TestLoadDelays()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/";

            IWebElement element = driver.FindElement(By.LinkText("Load Delay"));
            element.Click();
        }

        private static void TestUpload()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/upload";

            IWebElement fileInput = driver.FindElement(By.Id("file-upload"));
            string filePath = @"C:\path\to\your\file.txt";
            fileInput.SendKeys(filePath);

        }

        private static void TestHidingButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\Drivers\\FirefoxPortable\\App\\Firefox64\\firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\Selenium\\Selenium\\Drivers", options);
            driver.Url = "http://www.uitestingplayground.com/scrollbars";

            IWebElement element = driver.FindElement(By.Id("hidingButton"));
            element.Click();
        }
    }
}