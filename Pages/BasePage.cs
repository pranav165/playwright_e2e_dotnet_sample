using Microsoft.Playwright;

namespace NUnitPlaywrightProject.Pages
{
    public class BasePage
    {
        protected readonly IPage Page;

        public BasePage(IPage page)
        {
            Page = page;
        }
    }
}