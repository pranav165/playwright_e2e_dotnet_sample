using NUnit.Framework;
using System.Threading.Tasks;
using NUnitPlaywrightProject.Pages;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Tests
{
    public class GoogleSearchTests
    {
        private GooglePage googlePage;
        private IBrowser browser;

        [SetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            var page = await browser.NewPageAsync();

            googlePage = new GooglePage(page); // Pass the IPage instance here
            await googlePage.NavigateToGoogle();
        }

        [Test]
        public async Task SearchForApple()
        {
            await googlePage.SearchFor("apple");
            // Add assertions here to verify search results if needed
        }

        [Test]
        public async Task VerifyHeaderLinks()
        {
            Assert.IsTrue(await googlePage.Header.IsHeaderVisible(), "Header is not visible");
            await googlePage.Header.ClickGmailLink();
            // Add assertions to verify navigation to the Images page
        }

        [TearDown]
        public async Task Cleanup()
        {
            if (browser != null)
            {
                await browser.CloseAsync(); // Close the browser after each test
            }
        }
    }
}