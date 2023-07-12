using Microsoft.Playwright.NUnit;
using PlaywrightSpecFlow.Drivers;
using TechTalk.SpecFlow.Assist;
using TestPlaywright.src.Main.Pages;

namespace PlaywrightSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps : PageTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Driver _driver;
        private readonly LoginPage _loginPage;
        public LoginSteps(Driver driver) {
            _driver= driver;
            _loginPage=new LoginPage(_driver.Page);
        }

        [Given(@"I navigate to Login Page")]
        public void GivenInavigatetoLoginPage()
        {
            _driver.Page.GotoAsync("https://opensource-demo.orangehrmlive.com/");
        }
        [When(@"I enter username and password")]
        public async Task WhenIEnterUsernameAndPassword(Table table)
        {

            dynamic data = table.CreateDynamicInstance();

            await _loginPage.Login((string)data.UserName, (string)data.Password);
        }

           [When(@"I enter username :(.*) and password: (.*)")]
        public async Task WhenIEnterUsernameAndPassword(string username,string password)
        {

            await _loginPage.Login(username, password);
        }

        [When(@"I click on login button")]
        public async Task WhenIClickOnLoginButton()
        {
            await _loginPage.clickLogin();
        }

        [Then(@"I see the Dashboard page with Text '(.*)'")]
        public async Task ThenISeeTheDashboardPage(string txtMsg)
        {
            await _loginPage.isDashboardDisplayed(txtMsg);
  
        }


    }
}