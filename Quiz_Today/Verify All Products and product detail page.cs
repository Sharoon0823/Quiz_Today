using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Quiz_Today
{
    internal class Verify_All_Products_and_product_detail_page : Common_Method
    {
        By Home = By.XPath("//i[@class='fa fa-home']");
        By products = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[2]/a");
        By All_Products = By.XPath("//h2[@class='title text-center']");
        By firstProductView = By.XPath("//a[@href=\'/product_details/1\']");
        By ProductName = By.XPath("//h2[text() ='Blue Top']");
        By Category = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/p[1]");
        By price = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/span");
        By availability = By.XPath("//b[text() ='Availability:']");


        #region Constructor
        public Verify_All_Products_and_product_detail_page(IWebDriver driver)
        {
            commonDriver = driver;
        }
        #endregion


        #region For Verify Home Page
        public void ForVerifyHomePage()
        {
            IsElementVisible(Home);
            Console.WriteLine("Home page is Visible");
            Thread.Sleep(2000);
            CLick(products);
            Thread.Sleep(1000);
            IsElementVisible(All_Products);
            Console.WriteLine("On All products page");
            CLick(firstProductView);
            
            
            IsElementVisible(price);
            Console.WriteLine("Price Visible");
            
              IsElementVisible(Category);
            Console.WriteLine("Category Visible");
            
            IsElementVisible(ProductName);
            Console.WriteLine("Product NAme visible");
            
            IsElementVisible(availability);
            Console.WriteLine("Availabilty visible");

            commonDriver.Close();

        }
        #endregion
    }
}