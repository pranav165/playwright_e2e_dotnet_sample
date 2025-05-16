using NUnit.Framework;
using System.Threading.Tasks;
using Reqnroll;
using NUnitPlaywrightProject.Pages;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Tests
{
    [Binding]
    public class GoogleSearchSteps
    {
        private readonly GooglePage googlePage;

        public GoogleSearchSteps()
        {
            // Initialize Playwright and GooglePage
            var playwright = Playwright.CreateAsync().Result;
            var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false }).Result;
            var page = browser.NewPageAsync().Result;

            googlePage = new GooglePage(page);
        }

        [Given(@"I navigate to the Google homepage")]
        public async Task GivenINavigateToTheGoogleHomepage()
        {
            await googlePage.NavigateToGoogle();
        }

        [When(@"I search for ""(.*)""")]
        public async Task WhenISearchFor(string query)
        {
            await googlePage.SearchFor(query);
        }

        [Then(@"I should see search results")]
        public void ThenIShouldSeeSearchResults()
        {
            // Add assertions to verify search results
        }

        [When(@"I click on the Gmail link in the header")]
        public async Task WhenIClickOnTheGmailLinkInTheHeader()
        {
            await googlePage.Header.ClickGmailLink();
        }

        [Then(@"I should be redirected to the Gmail page")]
        public void ThenIShouldBeRedirectedToTheGmailPage()
        {
            // Add assertions to verify Gmail page navigation
        }
    }
}