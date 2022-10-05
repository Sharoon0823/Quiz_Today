using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Drawing.Drawing2D;


namespace Quiz_Today
{
    [TestClass]
    public class Automation
    {

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        String URL1 = "https://automationexercise.com/test_cases";
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "RegData.XML" , "Loginwithvalid" , DataAccessMethod.Sequential)]
        public void ForRegistration()
        {

            string fname = TestContext.DataRow["name"].ToString();
            string lastname = TestContext.DataRow["lastname"].ToString();


                  IWebDriver aDriver = Common_Method.driver("Chrome");
              aDriver.Manage().Window.Maximize();

             // aDriver.Url = "https://automationexercise.com/test_cases";
              aDriver.Navigate().GoToUrl(URL1);

              RegisterUser ru = new RegisterUser(aDriver);

              ru.Click_signUp();
              //ru.Assertion("Home","Home");
              ru.Click_Namee();
              ru.Enter_Name("Sharoon");
              ru.Click_Email();
              ru.Enter_Email("SharoonKhaliq88884@gmail.com");
              ru.Click_Submitt();
              ru.ForPassword("S090008900");
              ru.CLick_date();
              ru.Click_First_Lastname(fname , lastname , "Contour" , "Lahore", "Isb" , "IDK" , "Lahore" , "1234","03057633796");
         
        }




    }
    }
