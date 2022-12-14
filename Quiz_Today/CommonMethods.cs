using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Threading;
using System;




namespace Quiz_Today
{
    public class Common_Method
    {
        public static IWebDriver commonDriver;
        Actions Action;

        #region For Drivers
        public static IWebDriver driver(string driver)
        {
            if (driver == "Chrome")
            {
                commonDriver = new ChromeDriver();
            }
            else if (driver == "firefox")
            {
                commonDriver = new FirefoxDriver();
            }
            return commonDriver;
        }
        #endregion


        #region For Assertion

        public void Assertion(String Actual , string Expected)
        {
            Assertion(Actual, Expected);
        }
        #endregion

        #region Log4net
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        // frequent_methods


        #region Find Element

        public IWebElement findElement(By Locate)
        {
            return commonDriver.FindElement(Locate);

        }

        #endregion







        #region SendTextInput Field

        public void setText(By locate, string text)
        {
            IWebElement findedElement = findElement(locate);
            findedElement.Clear();
            //removeText(findedElement);
            findedElement.SendKeys(text + Keys.Tab);

        }
        #endregion

        #region Click on the Element

        public void CLick(By locator)
        {
            Action = new Actions(commonDriver);
            Action.Click(findElement(locator)).Build().Perform();

        }
        #endregion


        #region Reomove Text
        public void removeText(IWebElement element)
        {
            int a = element.Text.Length;

            while (a > 0)
            {
                element.SendKeys(Keys.Backspace);
            }
        }
        #endregion

        #region For CLose
        public static void ForClose()
        {
            commonDriver.Close();
        }
        #endregion

        #region For Sleep
        public static void ForSleep()
        {
            Thread.Sleep(5000);

        }
        #endregion

        #region For URL

        public void FOrUrl(string url)
        {
            commonDriver.Url = url;
        }
        #endregion


        #region Find elements by Value , InnerHTML
        public string getElementText(By Locator)
        {
            string text;
            try
            {
                text = findElement(Locator).Text;
            }
            catch
            {
                try
                {
                    text = findElement(Locator).GetAttribute("Value");
                }
                catch
                {
                    text = findElement(Locator).GetAttribute("innerHTML");
                }
            }
            return text;
        }


#region GetElement STate
        public string getElementState(By by)
        {
            string elementState = commonDriver.FindElement(by).GetAttribute("Disabled");
            if (elementState == null)
            {
                elementState = "enabled";
            }
            else if (elementState == "true")
            {
                elementState = "disabled";
            }
            return elementState;

        }
        #endregion


        #region ExecuteJavaScriptCode
        public static string ExecuteJavaScriptCode(string javascriptCode)
        {
            string value = null;
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)commonDriver;
                value = (string)js.ExecuteScript(javascriptCode);
            }
            catch (Exception)
            {

            }
            return value;
        }
        #endregion



        #region Wait for Element
        private IWebElement WaitForELement(By by, int timeToReadyElement = 0)
        {
            IWebElement element = null;
            try
            {
                if (timeToReadyElement != 0 && timeToReadyElement.ToString() != null)
                {
                    //PlaybackWait(timeToReadyElement * 1000);
                    timeToReadyElement = timeToReadyElement * 1000;
                }
                element = commonDriver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(commonDriver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true && IsClickable(by) == true);
                element = commonDriver.FindElement(by);
            }
            return element;
        }
        #endregion

        #region Element Visible
        public bool IsElementVisible(By by)
        {
            return (findElement(by).Displayed || findElement(by).Enabled) ? true : false;

        }
        #endregion


        #region IS PAge Ready
        private bool IsPageReady(IWebDriver driver)
        {
            return ExecuteJavaScriptCode("return document.readyState").Equals("complete");
        }
        #endregion
        //private void PlaybackWait(int v)
        //{
        //    throw new NotImplementedException();
        //}

        #region Element Present
        private bool IsElementPresent(By by)
        {
            try
            {
                commonDriver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        #endregion

        #region Clickable
        private bool IsClickable(By by)
        {
            try
            {
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region For DropDown ELement
        public void dropDown(By locator , string a)
        {
            SelectElement drop = new SelectElement(commonDriver.FindElement(locator));
            drop.SelectByValue(a);
        }
        #endregion


        #region Scroll Down
        public void scrollToElement(By locator)
        {


            IWebElement state = WaitForELement(locator);
            IJavaScriptExecutor commonExecuter = (IJavaScriptExecutor)commonDriver;
            commonExecuter.ExecuteScript("arguments[0].scrollIntoView(true); ", state);


        }
        #endregion

    }


}

#endregion