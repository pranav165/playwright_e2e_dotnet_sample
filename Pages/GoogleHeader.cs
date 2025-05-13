using System.Threading.Tasks;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Pages
{
    public class GoogleHeader
    {
        private readonly IPage _page;

        public GoogleHeader(IPage page)
        {
            _page = page;
        }

        public async Task ClickImagesLink()
        {
            // Click on the "Images" link in the header
            await _page.ClickAsync("a[href*='tbm=isch']");
        }

        public async Task ClickGmailLink()
        {
            // Click on the "Gmail" link in the header
            await _page.ClickAsync("a[href*='mail.google.com']");
        }

        public async Task<bool> IsHeaderVisible()
        {
            // Check if the header is visible
            return await _page.IsVisibleAsync("header");
        }
    }
}