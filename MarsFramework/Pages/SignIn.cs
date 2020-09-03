using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            String BaseUrl = GlobalDefinitions.ExcelLib.ReadData(3, "Url");
            String Username = GlobalDefinitions.ExcelLib.ReadData(3, "Username");
            String Pwd = GlobalDefinitions.ExcelLib.ReadData(3, "Password");

            GlobalDefinitions.driver.Navigate().GoToUrl(BaseUrl);

            SignIntab.Click();
            Email.SendKeys(Username);
            Password.SendKeys(Pwd);
            LoginBtn.Click();

        }
    }
}