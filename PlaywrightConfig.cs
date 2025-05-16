using Microsoft.Playwright;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace NUnitPlaywrightProject
{
    public static class PlaywrightConfig
    {
        private static dynamic _config;

        static PlaywrightConfig()
        {
            // Load settings from playwright.config.json
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "playwright.config.json");
            var configJson = File.ReadAllText(configPath);
            _config = JsonSerializer.Deserialize<dynamic>(configJson);
        }

        public static async Task<IBrowser> GetBrowserAsync()
        {
            var playwright = await Playwright.CreateAsync();
            var headless = _config["use"]["headless"] ?? true;

            return await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = headless
            });
        }

        public static async Task<IPage> GetPageAsync(IBrowser browser)
        {
            var viewportWidth = _config["use"]["viewport"]["width"] ?? 1280;
            var viewportHeight = _config["use"]["viewport"]["height"] ?? 720;
            var ignoreHTTPSErrors = _config["use"]["ignoreHTTPSErrors"] ?? true;

            var context = await browser.NewContextAsync(new BrowserNewContextOptions
            {
                ViewportSize = new ViewportSize { Width = (int)viewportWidth, Height = (int)viewportHeight },
                IgnoreHTTPSErrors = ignoreHTTPSErrors,
                RecordVideoDir = "playwright-report/videos",
                RecordVideoSize = new RecordVideoSize { Width = (int)viewportWidth, Height = (int)viewportHeight }
            });

            return await context.NewPageAsync();
        }

        public static async Task StartTracingAsync(IBrowserContext context)
        {
            await context.Tracing.StartAsync(new TracingStartOptions
            {
                Screenshots = true,
                Snapshots = true,
                Sources = true
            });
        }

        public static async Task StopTracingAsync(IBrowserContext context, string tracePath)
        {
            await context.Tracing.StopAsync(new TracingStopOptions
            {
                Path = tracePath
            });
        }
    }
}