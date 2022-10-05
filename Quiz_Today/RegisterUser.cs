using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Quiz_Today
{
    public class RegisterUser : Common_Method
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


        #region Constructor
        public RegisterUser(IWebDriver driver)
        {
            commonDriver = driver;
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
            setText(Click_Name, Setname);
        }
        #endregion

        #region For CLick on Email Field
        public void Click_Email()
        {
            CLick(Email);
        }
        #endregion


        #region Enter Email
        public void Enter_Email(string mail)
        {
            setText(Email, mail);
        }
        #endregion

        #region CLick on Submit Button
        public void Click_Submitt()
        {
            CLick(CLick_Submit);
            CLick(title);
        }
        #endregion

        #region Click and enter password
        public void ForPassword(string p)
        {
            CLick(Password);
            setText(Password, p);
            
            
        }

        #endregion

        #region For Click on Date
        public void CLick_date()
        {
            
           // Thread.Sleep(2000);
            dropDown(Date, "23");
            dropDown(Month, "1");
            dropDown(year, "2000");
            CLick(SignUp_newsletter);
            CLick(Special_offer);
        }
        #endregion

        #region CLick and ENter First Name
         public void Click_First_Lastname(string a , string b , string c , string add , string addd , string statee , string cityy , string zp, string mb)
        {
            CLick(FirstName);
            setText(FirstName, a);
            CLick(LastName);
            setText(LastName, b);
            CLick(Company_Name);
            setText(Company_Name, c);
            CLick(address01);
            setText(address01, add);
            CLick(address02);
            setText(address02, addd);
            dropDown(country, "Singapore");
            CLick(state);
            setText(state, statee);
            CLick(city);
            setText(city, cityy);
            CLick(zipcode);
            setText(zipcode, zp);
            CLick(mobile_number);
            setText(mobile_number, mb);
            CLick(SUbmit);
            CLick(Continue);
            IsElementVisible(Name_visible);

        }

        #endregion

    }
}