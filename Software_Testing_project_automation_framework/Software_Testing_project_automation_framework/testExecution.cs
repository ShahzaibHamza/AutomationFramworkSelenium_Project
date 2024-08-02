using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SoftwareTestingProject_AutomationFramework.WebApp.Cart;
using SoftwareTestingProject_AutomationFramework.WebApp.Checkout_Page;
using SoftwareTestingProject_AutomationFramework.WebApp.loginPage;
using SoftwareTestingProject_AutomationFramework.WebApp.OrderCompletion;
using SoftwareTestingProject_AutomationFramework.WebApp.ProductsPage;
using System;

namespace SoftwareTestingProject_AutomationFramework
{
    [TestClass]
    public class TestExecution
    {

        LoginPage loginpage = new LoginPage();
        ProductsPage productpage = new ProductsPage();
        AddToCart addToCart = new AddToCart();
        Checkout checkout = new Checkout();
        UserInfoForm userinfo = new UserInfoForm();
        OrderCompletionPage ordercomplete = new OrderCompletionPage();


        [DataTestMethod]
        [DataRow("https://www.saucedemo.com/", "standard_user", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "visual_user", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "problem_user", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "performance_glitch_user", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "error_user", "secret_sauce")]

        public void LoginWithValidUserValidPassword_TC001(string url, string username, string password)
        {
            CorePage.SeleniumInit();
            loginpage.Login(url, username, password);
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
       
        public void SelectProduct_TC002() 
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }


        [TestMethod]
        public void addItemToCart_TC003() 
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void Checkout_TC004()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void filloutCheckoutForm_TC005()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill("Shahzaib", "Hamza", "7740-Korangi");
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void OrderCompletion_TC006()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill("Shahzaib", "Hamza", "7740-Korangi");
            ordercomplete.clickFinish();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            //CorePage.driver.Close();
        }


        [DataTestMethod]
        [DataRow("https://www.saucedemo.com/", "s1233", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "visual_user", "sauce")]
        [DataRow("https://www.saucedemo.com/", "problser", "secret_sauce")]
        [DataRow("https://www.saucedemo.com/", "pernce_glitch_user", "sauce")]
        [DataRow("https://www.saucedemo.com/", "locked_out_user", "ret_sauce")]
        [DataRow("https://www.saucedemo.com/", "error", "secret_sauce")]

        public void LoginWithinValidUserinValidPassword_TC001(string url, string username, string password)
        {
            CorePage.SeleniumInit();
            loginpage.Login(url, username, password);
            CorePage.driver.Close();
        }


        [TestMethod]
        public void ClickOnBackToProductsFromProductCards_TC007()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            productpage.clickOnBack();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }


        [TestMethod]
        public void removeitemfromCart_TC008()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            addToCart.removeFromCart();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            CorePage.driver.Close();
        }

        [TestMethod]
        public void CheckoutWithoutFillingForm_TC009()
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            CorePage.driver.Close();
        }

        [DataTestMethod]
        [DataRow("shahzaib", "hamza", "7740")]
        [DataRow("sarfaraz", "soomro", "7540")]
        [DataRow("maher", "shahid", "8888")]
        [DataRow("arsalan", "ameer", "9876")]
        [DataRow("zohaib", "ahsan", "0987")]
        [DataRow("ahmed", "arham", "2456")]
        public void CheckoutByFillingDifferentData_TC0010(String fname, String lname, String postal)
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill(fname, lname, postal);
            ordercomplete.clickFinish();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            //CorePage.driver.Close();
        }
        
        
        [DataTestMethod]
        [DataRow("zohaib", "ahsan", "0987")]
        [DataRow("ahmed", "arham", "2456")]
        public void CheckBackToHome_TC0011(String fname, String lname, String postal)
        {
            CorePage.SeleniumInit();
            loginpage.Login("https://www.saucedemo.com/", "standard_user", "secret_sauce");
            productpage.ClickOnItem();
            addToCart.addItemToCart();
            checkout.clickCheckout();
            userinfo.userinfofill(fname, lname, postal);
            ordercomplete.clickFinish();
            ordercomplete.ClickBackToHome();
            String actualText = CorePage.driver.FindElement(By.ClassName("app_logo")).Text;
            Assert.AreEqual("Swag Labs", actualText);
            //CorePage.driver.Close();
        }

    }

    
}