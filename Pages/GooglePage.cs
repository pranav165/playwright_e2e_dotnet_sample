using System.Threading.Tasks;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Pages
{
    public class GooglePage : BasePage
    {
        private readonly IPage _page;

        public GoogleHeader Header { get; }

        public GooglePage(IPage page) : base(page)
        {
            _page = page;
            Header = new GoogleHeader(page);
        }

        public async Task NavigateToGoogle()
        {
            await _page.GotoAsync("https://www.google.com");
        }

        public async Task SearchFor(string query)
        {
            await _page.FillAsync("//*[@name='q']", query);
            await _page.PressAsync("//*[@name='q']", "Enter");
        }
    }
}