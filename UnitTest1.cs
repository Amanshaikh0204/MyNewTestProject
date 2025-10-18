namespace MyNewTestProject
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
       [Test]
    public void GetStartedLink()
    {
        using var playwright = Playwright.CreateAsync().GetAwaiter().GetResult();
        var browser = playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        }).GetAwaiter().GetResult();

        var context = browser.NewContextAsync().GetAwaiter().GetResult();
        var page = context.NewPageAsync().GetAwaiter().GetResult();

        page.GotoAsync("https://playwright.dev").GetAwaiter().GetResult();

        // Click the get started link
        page.GetByRole(AriaRole.Link, new() { Name = "Get started" })
            .ClickAsync().GetAwaiter().GetResult();

        // Verify Installation heading is visible
        var heading = page.GetByRole(AriaRole.Heading, new() { Name = "Installation" });
        
    }

    }
}
