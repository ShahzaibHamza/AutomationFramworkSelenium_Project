using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework
{
    public class CorePage
    {
        public static IWebDriver driver;

        public static IWebDriver SeleniumInit() 
        {
            IWebDriver chromeDriver = new ChromeDriver();
            driver = chromeDriver;
            return driver;
        }
    }
}
