using GiftreteWebProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace GiftreteWebProject.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        AutomationPage automationPage;

        public LoginSteps()
        {
            automationPage = new AutomationPage();
        }

        [Given(@"I click on Signin button")]
        public void GivenIClickOnSigninButton()
        {
            automationPage.ClickOnSigninButton();
        }

        [Given(@"I enter My Email Address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string email)
        {
            automationPage.MyEmailAddress(email);
        }

        [Given(@"I enter My Password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            automationPage.EnterMyPassword(password);
        }


        [Given(@"I Click Sigin")]
        public void GivenIClickSigin()
        {
            automationPage.ClickSigin();
        }


        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
           
        }

        [Given(@"I click on community")]
        public void GivenIClickOnCommunity()
        {
            automationPage.ClickOnCommunity();
        }

        [Given(@"I Click on My Community")]
        public void GivenIClickOnMyCommunity()
        {
            automationPage.ClickOnMyCommunity();
        }

        [Given(@"I Select My Community Page")]
        public void GivenISelectMyCommunityPage()
        {
            automationPage.SelectMyCommunityPage();
        }

        [Given(@"I Click on Manage Community")]
        public void GivenIClickOnManageCommunity()
        {
            automationPage.ClickOnManageCommunity();
        }

        [Given(@"I Change Community Name ""(.*)""")]
        public void GivenIChangeCommunityName(string name)
        {
            automationPage.ChangeCommunityName(name);
        }

        [Given(@"I Click Update Community")]
        public void GivenIClickUpdateCommunity()
        {
            automationPage.ClickUpdateCommunity();
        }

        [Then(@"A message ""(.*)""")]
        public void ThenAMessage(string Message)
        {
            automationPage.ThenAMessage();
            Assert.AreEqual(Message, automationPage.GetTextMessage());
        }






    }
}
