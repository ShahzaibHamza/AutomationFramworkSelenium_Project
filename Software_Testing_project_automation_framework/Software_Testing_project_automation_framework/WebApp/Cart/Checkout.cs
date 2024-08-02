using OpenQA.Selenium;
using SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareTestingProject_AutomationFramework.WebApp.Cart
{
    public class Checkout : CorePage
    {
        By cartBtn = By.ClassName("shopping_cart_link");
        By checkOutBtn = By.Id("checkout"); 
        
        public void clickCheckout() 
        {
            driver.FindElement(cartBtn).Click();
            driver.FindElement(checkOutBtn).Click();
        }
    }
}
