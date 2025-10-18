using Microsoft.Playwright;

namespace MyNewTestProject
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
<<<<<<< HEAD
        [Test]
        public async Task GetStartedLink()
        {
            await Page.GotoAsync("https://playwright.dev");

            // Click the get started link.
            await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();
=======
      [Test]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://playwright.dev");

        // Expect a title "to contain" a substring.
        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }
>>>>>>> 0ad94c15c71a25f6f35a8642b2476bfdf2af3d08

            // Expects page to have a heading with the name of Installation.
            await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
        }
    }
}
