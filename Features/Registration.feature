Feature: Registration
	In n order to use giftrete website
	I want to be register and create account

@mytag
Scenario: Registration
	Given I navigate to giftrete website "https://www.giftrete.com/"
	And I click on Create account
	And I enter Frist name "Joses"
	And I enter Last name "Ade"
	And I enter Email Address
	And I click Moble to select Country
	And I select United Kingdom as Country
	And I enter Mobile number "07412345678"
	And I enter Password "Password1"
	And I enter Confirm Password "Password1"
	And I click on Captcha
	And I click on register
	And the message "Thank you for signing up! You may now login"
	Then sign In page is displayed
