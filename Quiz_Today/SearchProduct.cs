using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Today
{
    internal class SearchProduct : Common_Method
    {
        By Home = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[1]/a");
        By Prod_click = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[2]/a");
        By Search = By.XPath("//*[@id='search_product']");
        By SearchEnter = By.XPath("//i[@class=\'fa fa-search\']");
        By SearchProductt = By.XPath("//h2[@class=\'title text-center\']");

        #region Constructor
        public SearchProduct(IWebDriver driver)
        {
            commonDriver = driver;
        }
        #endregion



        #region ForFunctionality
        public void SearchFUn(string search)
        {
            IsElementVisible(Home);
            Console.WriteLine("On Home Page");
            CLick(Prod_click);
            IsElementVisible(Prod_click);
            Console.WriteLine("On All Products Page");
            CLick(Search);
            setText(Search, search);
            CLick(SearchEnter);
            IsElementVisible(SearchProductt);
            Console.WriteLine("Visible");

            //For Screenshot
            ((ITakesScreenshot)commonDriver).GetScreenshot().SaveAsFile("SearchProduct.png");

           
        }
        #endregion
    }
}
