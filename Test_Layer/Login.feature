Feature: Login Functionality
  As a user of Swag Labs
  I want to be able to log in with valid credentials
  So that I can access the application

  Scenario: Successful Login
    Given the user is on the login page
    When the user enters valid credentials
    Then the user is redirected to the products page

  Scenario: Invalid Login
    Given the user is on the login page
    When the user enters invalid credentials
    Then the user sees an error message