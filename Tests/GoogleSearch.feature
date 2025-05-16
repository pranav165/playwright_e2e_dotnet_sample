Feature: Google Search
  As a user
  I want to search for information on Google
  So that I can find relevant results

  Scenario: Search for "apple"
    Given I navigate to the Google homepage
    When I search for "apple"
    Then I should see search results

  Scenario: Verify header links
    Given I navigate to the Google homepage
    When I click on the Gmail link in the header
    Then I should be redirected to the Gmail page