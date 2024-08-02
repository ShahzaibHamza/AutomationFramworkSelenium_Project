using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SoftwareTestingProject_AutomationFramework.WebApp.Cart;
using SoftwareTestingProject_AutomationFramework.WebApp.Checkout_Page;
using SoftwareTestingProject_AutomationFramework.WebApp.loginPage;
using SoftwareTestingProject_AutomationFramework.WebApp.OrderCompletion;
using SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage;
namespace SoftwareTestingProject_AutomationFramework.WebApp
{
    [TestClass]
    public class testExecution2: CorePage
    {
        LoginPage loginpage = new LoginPage();
        AddToCart addToCart = new AddToCart();
        Checkout checkout = new Checkout();
        UserInfoForm userinfo = new UserInfoForm();
        OrderCompletionPage ordercomplete = new OrderCompletionPage();

       

    }
}
