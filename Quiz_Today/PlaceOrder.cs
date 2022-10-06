using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Quiz_Today
{
    [TestClass]
    public class PlaceOrder : Common_Method
    {
        private static readonly log4net.ILog log =
     log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        By Click_SignUp = By.XPath("//*[@id=\'header\']/div/div/div/div[2]/div/ul/li[4]/a");
        By Click_Name = By.XPath("//input[@type ='text']");
        By Email = By.XPath("//input[@name = 'email' and @type = 'email' and @placeholder ='Email Address' and @data-qa = 'signup-email']");
        By CLick_Submit = By.XPath("//button[@type = 'submit'  and @data-qa = 'signup-button' ] ");
        By title = By.XPath("//input[@type=\"radio\" and @id=\"id_gender1\" ]");
        By Home = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[1]/a");
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




        #region Constructor
        public PlaceOrder(IWebDriver driver)
        {
            commonDriver = driver;
        }

     



        #endregion


        #region Click Product Button
        public void CLick_Product()
        {
            log.Info("Click on Products");
            CLick(Prod_click);
            log.Info("Hover_over on Element");
            scrollToElement(Selement);
            Thread.Sleep(2000);
            log.Info("Click on element");
            CLick(ADDCART);
            Thread.Sleep(2000);
            CLick(CLick_CSHopping);
            Thread.Sleep(1000);
            CLick(cart);
            CLick(checkout);
           CLick(Register);
      

           

        }
        #endregion



   #region CLick_SignUp
public void Click_signUp()
{
    log.Info("Click on Signup");
    CLick(Click_SignUp);
}
#endregion






#region Click on  Name Field
public void Click_Namee()
{
    log.Info("Click on Name");
    CLick(Click_Name);
}

#endregion

#region Enter Name 
public void Enter_Name(String Setname)
{
    log.Info("Name is set");
    setText(Click_Name, Setname);
}
#endregion

#region For CLick on Email Field
public void Click_Email()
{
    log.Info("Click on email");
    CLick(Email);
}
#endregion


#region Enter Email
public void Enter_Email(string mail)
{
    log.Info("Email ENtered");
    setText(Email, mail);
}
#endregion

#region CLick on Submit Button
public void Click_Submitt()
{
    log.Info("Click on submit and title");
    CLick(CLick_Submit);
    CLick(title);
}
#endregion

#region Click and enter password
public void ForPassword(string p)
{
    log.Info("Click and Set password");
    CLick(Password);
    setText(Password, p);


}

#endregion

#region For Click on Date
public void CLick_date()
{

    // Thread.Sleep(2000);
    log.Info("date Set");
    dropDown(Date, "23");
    log.Info("Month set");
    dropDown(Month, "1");
    log.Info("year set");
    dropDown(year, "2000");
    log.Info("Check newsletter");
    CLick(SignUp_newsletter);
    log.Info("Check Special Offer");
    CLick(Special_offer);
}
#endregion

#region CLick and ENter First Name
 public void Click_First_Lastname(string a , string b , string c , string add , string addd , string statee , string cityy , string zp, string mb , string cmnt , string Ncard , string cn , string cvc , string mnth , string year)
{
    log.Info("Click on First name");
    CLick(FirstName);
    log.Info("set text for First name");
    setText(FirstName, a);
    log.Info("Click on last name");
    CLick(LastName);
    log.Info("set text for last name");
    setText(LastName, b);
    log.Info("Click on Company name");
    CLick(Company_Name);
    log.Info("Set text for Company name");
    setText(Company_Name, c);
    log.Info("Click on Address 01");
    CLick(address01);
    log.Info("Set text for address 01 ");
    setText(address01, add);
    log.Info("Click on Address 02");
    CLick(address02);
    log.Info("Set text for address 02 ");
    setText(address02, addd);
    log.Info("Set text for Country");
    dropDown(country, "Singapore");
    log.Info("Click on State");
    CLick(state);
    log.Info("Set text for State");
    setText(state, statee);
    log.Info("Click on City ");
    CLick(city);
    log.Info("Set text for City");
    setText(city, cityy);
    log.Info("Click on ZipCode ");
    CLick(zipcode);
    log.Info("Set text for Zipcode ");
    setText(zipcode, zp);
    log.Info("CLick on Mobile Number");
    CLick(mobile_number);
    log.Info("Set text for Mobile Number ");
    setText(mobile_number, mb);
    log.Info("Click on submut");
    CLick(SUbmit);
    log.Info(" Click on continue");
    CLick(Continue);
    log.Info("Element is Visible");
    IsElementVisible(Namee_visible);
    CLick(cart);
            CLick(checkout);
            CLick(comment);
            setText(comment, cmnt);
            CLick(placeO);
            Thread.Sleep(1000);
            CLick(cardName);
            Thread.Sleep(1000);
            setText(cardName, Ncard);
            CLick(cardNum);
            setText(cardNum, cn);
            CLick(CVC);
            setText(CVC, cvc);
            CLick(Expiration_mnth);
            setText(Expiration_mnth, mnth);
            CLick(Expiration_year);
            setText(Expiration_year, year);
            CLick(PayConfirm);
            IsElementVisible(OConfirmed);

        }

        



        #endregion

    }
}