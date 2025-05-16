using System.Threading.Tasks;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Pages
{
    public class GoogleHeader : BasePage
    {
        public GoogleHeader(IPage page) : base(page)
        {
        }

        public async Task ClickImagesLink()
        {
            // Click on the "Images" link in the header
            await ClickAsync("a[href*='tbm=isch']"); // Using BasePage's ClickAsync method
        }

        public async Task ClickGmailLink()
        {
            // Click on the "Gmail" link in the header
            await ClickAsync("a[href*='mail.google.com']"); // Using BasePage's ClickAsync method
        }

        public async Task<bool> IsHeaderVisible()
        {
            // Check if the header is visible
            return await IsElementVisibleAsync("header"); // Using BasePage's IsElementVisibleAsync method
        }
    }
}