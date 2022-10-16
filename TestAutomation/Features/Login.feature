Feature: LoginPage

	User login to ecommerce web application

@External
Scenario Outline: User Login to Application
	Given User navigates to application login page
	When User login using credentials <UserName> and <PassWordType>
	Then I should sucessfully be logged in
		Examples: 
		| UserName            | PassWordType |
		| francis@yopmail.com | password |




