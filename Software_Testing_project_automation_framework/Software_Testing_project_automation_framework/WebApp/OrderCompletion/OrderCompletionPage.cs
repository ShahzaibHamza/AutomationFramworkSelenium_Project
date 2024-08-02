using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework.WebApp.OrderCompletion
{
    public class OrderCompletionPage : CorePage
    {
        By finishBtn = By.Id("finish");
        By backtohomebtn = By.Id("back-to-products");
        public void clickFinish() 
        {
            driver.FindElement(finishBtn).Click();
        }

        public void ClickBackToHome() 
        {
            driver.FindElement(backtohomebtn).Click();
        }
    }
}
