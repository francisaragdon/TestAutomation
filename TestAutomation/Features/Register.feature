Feature: Register

	User registers to the application

@tag1
Scenario: User registers to the application
	Given User Navigates to the home page
	When User inputs <email> on register field
	And User fills up required fields
	Then User is now registered

	Examples: 
	| Title | First Name | Last Name | Email                | Password | First_Name | Last_Name | Address | City | State | Zip  | Country | Mobile Phone | Address Alias |
	| Mr    | Francis    | Aragdon   | francis1@yopmail.com | password | Francis    | Aragdon   | Mnl     | Mnl  | Mnl   | 1700 | Ph      | 091234567    | Mnl Ph        | 