using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using Rhino.Mocks;

namespace PlaywrightSpecFlow.Drivers
{

    public class Driver : IDisposable
    {
        private readonly Task<IPage> _page;
        private IBrowser? _browser;
        public Driver() {

            _page = InitializePlaywright();
        }
        
        public IPage Page => _page.Result;

        public void Dispose()
        {
            _browser?.CloseAsync();
        }

        
        private async Task<IPage> InitializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();

            //Browser
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions 
            {
                Headless = false,
            });


            return await _browser.NewPageAsync();
        }     
         
        
    }
}
