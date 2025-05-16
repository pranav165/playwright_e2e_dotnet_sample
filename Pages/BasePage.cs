using Microsoft.Playwright;
using System.Threading.Tasks;

namespace NUnitPlaywrightProject.Pages
{
    public class BasePage
    {
        protected readonly IPage Page;

        public BasePage(IPage page)
        {
            Page = page;
        }

        // Method to click an element
        public async Task ClickAsync(string selector)
        {
            await Page.ClickAsync(selector);
        }

        // Method to type text into an input field
        public async Task TypeTextAsync(string selector, string text)
        {
            await Page.FillAsync(selector, text);
        }

        // Method to wait for an element to be visible
        public async Task WaitForElementAsync(string selector)
        {
            await Page.WaitForSelectorAsync(selector);
        }

        // Method to get the text content of an element
        public async Task<string> GetTextContentAsync(string selector)
        {
            return await Page.TextContentAsync(selector);
        }

        // Method to check if an element is visible
        public async Task<bool> IsElementVisibleAsync(string selector)
        {
            return await Page.IsVisibleAsync(selector);
        }

        // Method to navigate to a URL
        public async Task NavigateToAsync(string url)
        {
            await Page.GotoAsync(url);
        }
    }
}