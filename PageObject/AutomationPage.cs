using GiftreteWebProject.Hooks;
using GiftreteWebProject.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftreteWebProject.PageObject
{
    class AutomationPage
    {
        IWebDriver driver;

        Wait wait = new Wait();

        IWebElement createAccount => driver.FindElement(By.XPath("/html/body/section[1]/nav/div/div[1]/a[2]"));
        IWebElement fristName => driver.FindElement(By.XPath("//input[@id='first_name']"));
        IWebElement lastName => driver.FindElement(By.XPath("//input[@id='last_name']"));
        IWebElement emailAddress => driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement selectCountry => driver.FindElement(By.XPath("(//div[@class='iti-flag gb'])[1]"));
        IWebElement unitedKindomAsCounty => driver.FindElement(By.XPath("(//*[text()='United Kingdom'])[1]"));
        IWebElement mobileNumber => driver.FindElement(By.XPath("//input[@id='mobile']"));
        IWebElement passwordTest => driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement confirmPassword => driver.FindElement(By.XPath("//input[@name='confirm_password']"));
        IWebElement registerBtn => driver.FindElement(By.XPath("//input[@value='Register']"));
        IWebElement signinBtn => driver.FindElement(By.XPath("(//a[text()='Sign In'])[1]"));
        IWebElement sigin => driver.FindElement(By.XPath("//input[@value='Sign In']"));
        IWebElement myEmail => driver.FindElement(By.XPath("//input[@name='user_email']"));
        IWebElement myPassword => driver.FindElement(By.XPath("(//input[@type='password'])[1]"));
        IWebElement community => driver.FindElement(By.XPath("(//*[@class='mm-text'])[2]"));
        IWebElement myCommunity => driver.FindElement(By.XPath("//a[text()='My Communities']"));
        IWebElement myCommunityPage => driver.FindElement(By.XPath("//div[@class='ptb--10 plr--20']"));
        IWebElement manageCommunity => driver.FindElement(By.XPath("//a[@class='add-d']"));
        IWebElement communityName => driver.FindElement(By.XPath("(//input[@type='text'])[1]"));
        IWebElement updateCommunity => driver.FindElement(By.XPath("//input[@class='add-p']"));
        IWebElement messageDisplay => driver.FindElement(By.XPath("//*[@id='suc_msg']"));
        IWebElement signPage => driver.FindElement(By.XPath("//a[@role='tab'][1]"));
        IWebElement msgDisplay => driver.FindElement(By.XPath("//*[@id='suc_msg_t']"));


        public string GetPageTitle => driver.Title;

        public void ThenAMessage()
        {
            Assert.IsTrue(msgDisplay.Displayed);
        }
        
        public string GetTextMessage()
        {

            // return waits.WaitForElement(driver, errorMsg).Text;
            IWebDriver myDriver = driver;
            return wait.MyDriverWait(myDriver, msgDisplay).Text;
        }

        public void SignInPageIsDisplayed()
        {
            signPage.Click();
        }

        public void TheMessage()
        {
            Assert.IsTrue(messageDisplay.Displayed);
        }

         public string GetTextForMessage()
         {

            // return waits.WaitForElement(driver, errorMsg).Text;
            IWebDriver myDriver = driver;
            return wait.MyDriverWait(myDriver, messageDisplay).Text;

         }

        public void ClickUpdateCommunity()
        {
            updateCommunity.Click();
        }
        public void ChangeCommunityName(string name)
        {
            communityName.Clear();
            communityName.SendKeys(name);
            
        }
       
        public void ClickOnManageCommunity()
        {
            manageCommunity.Click();
        }
        public void SelectMyCommunityPage()
        {
            myCommunityPage.Click();
        }
        public void ClickOnMyCommunity()
        {
            myCommunity.Click();
        }
        public void ClickOnCommunity()
        {
            community.Click();
        }

        public void EnterMyPassword(string password)
        {
            myPassword.SendKeys(password);
        }
        public void MyEmailAddress(string email)
        {
            myEmail.SendKeys(email);
        }
        public void ClickSigin()
        {
            sigin.Click();
        }
        public void ClickOnSigninButton()
        {
            signinBtn.Click();
        }
        public void ClickOnRegister()
        {
            registerBtn.Click();
            wait.WaitForElement(driver, messageDisplay).Click();
            registerBtn.Click();
        }
        public void EnterConfirmPassword(string ConPassword)
        {
            confirmPassword.SendKeys(ConPassword);
        }

        public void EnterPassword(string password)
        {
            passwordTest.SendKeys(password);
        }
        public void EnterMobileNumber(string mobile)
        {
            mobileNumber.SendKeys(mobile);
        }
        public void UnitedKingdomAsCountry()
        {
            unitedKindomAsCounty.Click();
        }
        public void MobleToSelectCountry()
        {
            selectCountry.Click();
        }

        public void EnterEmailAddress()
        {
            Random randomgenerator = new Random();
            int randomInt = randomgenerator.Next(1000);
            emailAddress.SendKeys("moscoade" + randomInt + "@yahoo.com");
        }
       

        public void EnterLastName(string last)
        {
            lastName.SendKeys(last);
        }
        public void EnterFristName(string frist)
        {
            fristName.SendKeys(frist);
        }
        public void ClickOnCreateAccount()
        {
            createAccount.Click();
           
        }
        public AutomationPage()
        {
            driver = Hook.driver;
        }


   
        public void NavigateToGiftreteWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

    }
}
