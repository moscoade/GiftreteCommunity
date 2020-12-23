Feature: Login
	In order to use giftrete website after registration
	I need to login

@mytag
Scenario: Login
	Given I navigate to giftrete website "https://www.qa.giftrete.com/"
    And I click on Signin button 
	Given I enter My Email Address "moscoade@yahoo.com"
	And I enter My Password "Password1"
	And I Click Sigin
	And I click on community
	And I Click on My Community
	And I Select My Community Page
	And I Click on Manage Community
	And I Change Community Name "MoscoTesting"
	And I Click Update Community
	Then A message "Your Community has been Updated successfully"


	