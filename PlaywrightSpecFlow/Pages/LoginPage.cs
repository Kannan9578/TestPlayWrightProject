using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPlaywright.src.Main.Pages
{
    
    public class LoginPage : PageTest
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }
               public async Task enterUserName(String userName)
        {
            await _page.Locator("[name='username']").FillAsync(userName);
        }

     
        public async Task enterPassword(String password)
        {
            await _page.Locator("[name='password']").FillAsync(password);
        }

     
        public async Task clickLogin()
        {
            await _page.Locator("button[type='submit']").ClickAsync();
        }

        public async Task isDashboardDisplayed(string txtContent)
        {
            await Expect(_page.Locator("h6")).ToContainTextAsync(txtContent);
        }

        public async Task Login(string username,string password)
        {
            await enterUserName(username);
            await enterPassword(password);
        }
    }
}
