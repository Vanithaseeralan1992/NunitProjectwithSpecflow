Feature: Gmailfeature
	Simple calculator for adding two numbers

@mytag
Scenario: Gmail Login
	Given Launch firefox browser 
	And Navigate to Gmail page
	When I click login 
	And Enter username and password
	When I click login 
	Then User is loggedin 