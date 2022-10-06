using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Today
{
    internal class DownloadInvoiceAfterPurchase : Common_Method
    {
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        By Click_SignUp = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[4]/a");
        By Click_Name = By.XPath("//input[@type ='text']");
        By Email = By.XPath("//input[@name = 'email' and @type = 'email' and @placeholder ='Email Address' and @data-qa = 'signup-email']");
        By CLick_Submit = By.XPath("//*[@id=\'form\']/div/div/div[3]/div/form/button ");
        By title = By.XPath("//input[@type=\'radio\' and @id=\'id_gender1\' ]");
        By Home = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[1]/a");
        By Password = By.XPath("//input[@id='password']");
        By Date = By.Name("days");
        By Month = By.Name("months");
        By year = By.Name("years");
        By SignUp_newsletter = By.Name("newsletter");
        By Special_offer = By.Name("optin");
        By FirstName = By.Name("first_name");
        By LastName = By.Name("last_name");
        By Company_Name = By.Name("company");
        By address01 = By.Name("address1");
        By address02 = By.Name("address2");
        By country = By.Name("country");
        By state = By.Name("state");
        By city = By.Name("city");
        By zipcode = By.Name("zipcode");
        By mobile_number = By.Name("mobile_number");
        By SUbmit = By.XPath("//*[@id=\"form\"]/div/div/div/div[1]/form/button");
        By Continue = By.XPath("//*[@id=\'form\']/div/div/div/div/a");
        By Name_visible = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[10]/a/b");
        By Prod_click = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[2]/a");
        By Selement = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/img");
        By ADDCART = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[1]/a");
        By CLick_CSHopping = By.XPath("//*[@id=\"cartModal\"]/div/div/div[3]/button");
        By cart = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[3]/a");
        By checkout = By.XPath("//a[@class='btn btn-default check_out']");
        By Register = By.XPath("//*[@id=\"checkoutModal\"]/div/div/div[2]/p[2]/a/u");
        By Namee_visible = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[10]/a/b");
        By comment = By.XPath("//textarea[@class='form-control']");
        By placeO = By.XPath("//a[@class='btn btn-default check_out']");
        By cardName = By.XPath("//*[@id=\"payment-form\"]/div[1]/div/input");
        By cardNum = By.XPath("//input[@name='card_number']");
        By CVC = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[1]/input");
        By Expiration_mnth = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[2]/input");
        By Expiration_year = By.XPath("//*[@id=\"payment-form\"]/div[3]/div[3]/input");
        By PayConfirm = By.XPath("//button[@class='form-control btn btn-primary submit-button']");
        By OConfirmed = By.XPath("//*[@id=\"form\"]/div/div/div/p");
        By Download = By.XPath("//a[@href=\'/download_invoice/500\']");

        #region Constructor
        public DownloadInvoiceAfterPurchase(IWebDriver driver)
        {
            commonDriver = driver;
        }
        #endregion

        PlaceOrder po = new PlaceOrder(commonDriver);
        #region
        public void Call(string name , string email , string pass)
        {
            IsElementVisible(Home);
            Console.WriteLine("On Home Page");
            
            po.CLick_Product();
            po.Click_Namee();
            po.Enter_Name(name);
            po.Click_Email();
            po.Enter_Email(email);
            po.Click_Submitt();
            po.ForPassword(pass);
            po.CLick_date();
            CLick(FirstName);
        }
        #endregion

        #region Call Values for remaining fields
        public void Call02(string a, string b, string c, string add, string addd, string statee, string cityy, string zp, string mb, string cmnt, string Ncard, string cn, string cvc, string mnth, string year)
        {
            po.Click_First_Lastname(a, b, c, add, addd, statee, cityy, zp, mb, cmnt, Ncard, cn, cvc, mnth, year);
            CLick(Download);
            string[] filepaths = Directory.GetFiles(@"C:\\Users\\kc\\Downloads");
            string file = null;
            foreach(string filepath in filepaths)
            {
                if(filepath == "C:\\Users\\kc\\Downloads\\invoice (1).txt")
                {
                    file = filepath;
                    Console.WriteLine(file);
                     Assert.IsTrue(file.Contains("invoice (1)"));

                }

            }
          
        }
        #endregion


    }
}
