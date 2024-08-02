using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework.WebApp.Checkout_Page
{
    public class UserInfoForm : CorePage
    {
        By fname = By.Id("first-name");
        By lname = By.Id("last-name");
        By postcode = By.Id("postal-code");
        By continueBtn = By.Id("continue");

        public void userinfofill(string firstname, string lastname, string postalcode) 
        {
            driver.FindElement(fname).SendKeys(firstname);
            driver.FindElement(lname).SendKeys(lastname);
            driver.FindElement(postcode).SendKeys(postalcode);
            driver.FindElement(continueBtn).Click();
        }
    }
}
