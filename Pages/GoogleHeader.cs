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

        public async Task ClickGmailLink()
        {
            // Click on the "Images" link in the header
            await _page.ClickAsync("//*[@id='gb']/div[1]/div[1]/a");
        }


        public async Task<bool> IsHeaderVisible()
        {
            // Check if the header is visible
            return await _page.IsVisibleAsync("//*[@name='q']");
        }
    }
}