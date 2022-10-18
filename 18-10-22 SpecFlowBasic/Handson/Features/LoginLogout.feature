Feature: LoginLogout
In order to access my account
    As a user of the website
   I want to log into the website

@mytag
Scenario Outline: Successful Login with Valid Credentials
    Given User is at the Home Page
    And Navigate to LogIn Page
    When User enter "testuser2" and "Test2@123"
    And Click on the LogIn button
    Then Successful LogIN message should display

Scenario: Successful LogOut
    When User LogOut from the Application
    Then Successful LogOut message should display
	
Scenario: AddProductstoCart
    Given list of products available
    And productscart empty initially

    When products added to cart validate cart

    Then if valid display "valid cart" message