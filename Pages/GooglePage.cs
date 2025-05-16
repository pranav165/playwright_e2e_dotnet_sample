using System.Threading.Tasks;
using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Pages
{
    public class GooglePage : BasePage
    {
        public GoogleHeader Header { get; }

        public GooglePage(IPage page) : base(page)
        {
            Header = new GoogleHeader(page);
        }

        public async Task NavigateToGoogle()
        {
            await NavigateToAsync("https://www.google.com"); // Using BasePage's NavigateToAsync method
        }

        public async Task SearchFor(string query)
        {
            await TypeTextAsync("//*[@name='q']", query); // Using BasePage's TypeTextAsync method
            await ClickAsync("//*[@name='btnK']"); // Using BasePage's ClickAsync method
        }
    }
}