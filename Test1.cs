using System.Text.RegularExpressions;
using Microsoft.Playwright;
using Microsoft.Playwright.MSTest;

namespace PlaywrightTests;

[TestClass]
public class ExampleTest : PageTest
{
    [TestMethod]
    public async Task AART_MainPageTitle()
    {
        await Page.GotoAsync("https://www.arrt.org/");
        // Verify AART's Title
        await Expect(Page).ToHaveTitleAsync("Welcome to the American Registry of Radiologic Technologists (ARRT) website - ARRT.org - ARRT");

    }

    [TestMethod]
    public async Task AART_AboutPage()
    {
        await Page.GotoAsync("https://www.arrt.org/");

        // Select About dropdown:
        await Page.Locator("[data-toggle='dropdown']").First.ClickAsync();

        // Select the About Us item
        await Page.GetByRole(AriaRole.Link, new() { Name = "About Us" }).ClickAsync();

        // // Verify About page has correct URL:
        await Expect(Page).ToHaveURLAsync("https://www.arrt.org/pages/about/about-us");

        // // verify About Page Title:
        await Expect(Page).ToHaveTitleAsync("Welcome to the American Registry of Radiologic Technologists (ARRT) website - ARRT.org - ARRT");
        var title = await Page.TitleAsync();
        Console.WriteLine("Ttitle: " + title); 
    }    
}
