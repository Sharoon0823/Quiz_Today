using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Quiz_Today
{
    internal class AddProductsInCart : Common_Method
    {


        By Home = By.XPath("//i[@class='fa fa-home']");
        By products = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[2]/a");
        By OnFirstProduct = By.XPath("//a[@href=\'/product_details/1\']");
        By OnSecondProduct = By.XPath("//a[@href=\'/product_details/2\']");
        By Submit = By.XPath("//button[@class=\"btn btn-default cart\"]");
        By continue_Shopping = By.XPath("//button[@data-dismiss='modal']");
        By viewCart = By.XPath("//*[@id=\'cartModal\']/div/div/div[2]/p[2]/a/u");

        By visible01 = By.XPath("//a[@href=\'/product_details/1\']");
        By visible02 = By.XPath("//a[@href=\'/product_details/2\']");



        #region Constructor
        public AddProductsInCart(IWebDriver driver)
        {
            commonDriver = driver;
        }
        #endregion

        #region  Home page is visible successfully

        public void ForPAgeVisible()
        {
            IsElementVisible(Home);
            Console.WriteLine("Home Page Visible Successfully");
            CLick(products);

            scrollToElement(OnFirstProduct);

            Actions action = new Actions(commonDriver);
            WebElement we = (WebElement)commonDriver.FindElement(By.XPath("//img[@alt='ecommerce website products' and @src='/get_product_picture/1']"));
            action.MoveToElement(we).Build().Perform();
            CLick(OnFirstProduct);
            CLick(Submit);
            Thread.Sleep(2000);
            CLick(continue_Shopping);
            CLick(products);

            WebElement wee = (WebElement)commonDriver.FindElement(By.XPath("//a[@href='/product_details/2']"));
            action.MoveToElement(wee).Build().Perform();
            CLick(OnSecondProduct);
            CLick(Submit);
            Thread.Sleep(2000);
            CLick(viewCart);
            IsElementVisible(visible01);
            Console.WriteLine("Product o1 is Visible");
            IsElementVisible(visible02);
            Console.Write("Product 02 is Visible");

            //For Screenshot
            ((ITakesScreenshot)commonDriver).GetScreenshot().SaveAsFile("AddProduct.png");

            commonDriver.Close();

        }
        #endregion
    }
}
