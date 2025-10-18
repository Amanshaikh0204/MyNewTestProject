using Microsoft.Playwright;

namespace MyNewTestProject
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public async Task GetStartedLink()
        {
            //Line123

            // Click the get started link.
            await Page.GetByRole(AriaRole.Link, new() { Name = "Get started" }).ClickAsync();
        }

      [Test]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://playwright.dev");

        //First Line
        //Second Line

            // Expects page to have a heading with the name of Installation.
            await Expect(Page.GetByRole(AriaRole.Heading, new() { Name = "Installation" })).ToBeVisibleAsync();
        }
    }
}
