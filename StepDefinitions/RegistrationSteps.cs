using GiftreteWebProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GiftreteWebProject.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        AutomationPage automationPage;

        public RegistrationSteps()
        {
            automationPage = new AutomationPage();
        }


        [Given(@"I navigate to giftrete website ""(.*)""")]
        public void GivenINavigateToGiftreteWebsite(string Url)
        {
            automationPage.NavigateToGiftreteWebsite(Url);
        }
        
        [Given(@"I click on Create account")]
        public void GivenIClickOnCreateAccount()
        {
            automationPage.ClickOnCreateAccount();
        }
        
        [Given(@"I enter Frist name ""(.*)""")]
        public void GivenIEnterFristName(string first)
        {
            automationPage.EnterFristName(first);
        }
        
        [Given(@"I enter Last name ""(.*)""")]
        public void GivenIEnterLastName(string last)
        {
            automationPage.EnterLastName(last);
        }

        [Given(@"I enter Email Address")]
        public void GivenIEnterEmailAddress()
        {
            automationPage.EnterEmailAddress();
        }

        [Given(@"I click Moble to select Country")]
        public void GivenIClickMobleToSelectCountry()
        {
            automationPage.MobleToSelectCountry();
        }


        [Given(@"I select United Kingdom as Country")]
        public void GivenISelectUnitedKingdomAsCountry()
        {
            automationPage.UnitedKingdomAsCountry();
        }
        
        [Given(@"I enter Mobile number ""(.*)""")]
        public void GivenIEnterMobileNumber(string mobile)
        {
            automationPage.EnterMobileNumber(mobile);
        }
        
        [Given(@"I enter Password ""(.*)""")]
        public void GivenIEnterPassword(string password)
        {
            automationPage.EnterPassword(password);
        }

        [Given(@"I enter Confirm Password ""(.*)""")]
        public void GivenIEnterConfirmPassword(string ConPassword)
        {
            automationPage.EnterConfirmPassword(ConPassword);
        }


        [Given(@"I click on Captcha")]
        public void GivenIClickOnCaptcha()
        {
           
        }
        
        [Given(@"I click on register")]
        public void GivenIClickOnRegister()
        {
            automationPage.ClickOnRegister();     

        }

        [Given(@"the message ""(.*)""")]
        public void GivenTheMessage(string message)
        {
            automationPage.TheMessage();
            Assert.AreEqual(message, automationPage.GetTextForMessage());
        }

        [Then(@"sign In page is displayed")]
        public void ThenSignInPageIsDisplayed()
        {
            automationPage.SignInPageIsDisplayed();
        }




    }
}
