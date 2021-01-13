using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver(@"C:\drivers");
        //web elements, usually i would try to put in a seporate page
        private IWebElement _createAnAccountButton => driver.FindElement(By.XPath("//div[@id='app-header']/div[2]/div/div[3]/a[2]"));
        private IWebElement _emailTextfield => driver.FindElement(By.Id("create_account_email"));
        private IWebElement _fNameTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[2]/div[1]/div[1]/input"));
        private IWebElement _lNameTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[2]/div[2]/div[1]/input"));
        private IWebElement _passwordTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[3]/div[1]/div[1]/input"));
        private IWebElement _confirmPasswordTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[3]/div[3]/div[1]/input"));
        private IWebElement _referedByTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[5]/div[1]/input"));
        private IWebElement _phoneTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[7]/div[1]/input"));
        private IWebElement _streetTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[9]/div[1]/input"));
        private IWebElement _cityTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[10]/div[1]/input"));
        private IWebElement _stateDropdown => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[11]/div[1]/div[1]/div/input"));
        private IWebElement _zipTextfield => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[11]/div[2]/div[1]/input"));
        private IWebElement _countryDropdown => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/form/div[12]/div[1]/div/input"));
        private IWebElement _investorYesRadiobutton => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/div[1]/div[1]/div[2]/div/label[1]/div"));
        private IWebElement _investorNoRadiobutton => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/div[1]/div[1]/div[2]/div/label[2]/div"));
        private IWebElement _termsOfServiceCheckbox => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div[1]/label/div"));
        private IWebElement _iUnderstandCheckbox => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/div[2]/div[1]/div[2]/label/div"));
        private IWebElement _captchaCheckbox => driver.FindElement(By.XPath("//*[@class='recaptcha-container']"));
        private IWebElement _signUpButton => driver.FindElement(By.XPath("//*[@id='content-well']/div[1]/div/div/div[1]/div/div/div[2]/button"));


        /// <summary>
        /// This test creates a new user account
        /// </summary>
        [Test]
        public void CreateANewAccountTest()
        {
            //got to URL https://test.crowdstreet.com/
            driver.Navigate().GoToUrl("https://test.crowdstreet.com/");
            System.Threading.Thread.Sleep(2000);

            //click create account
            _createAnAccountButton.Click();

            //find each and fill out text field
            //email, fname, lname, password, phone #, street address, city, state(dropdown), zip, investor(toggle), terms of service(checkbox), i understand(checkbox), captha
            //finally 'sign up' button is enabled

            //--!needs to be a unused email!--
            _emailTextfield.SendKeys("mrtest2@test.com");
            _fNameTextfield.SendKeys("Dude");
            _lNameTextfield.SendKeys("Test");
            _passwordTextfield.SendKeys("Crowdstreet123!");
            System.Threading.Thread.Sleep(500);
            _confirmPasswordTextfield.SendKeys("Crowdstreet123!");
            System.Threading.Thread.Sleep(500);
            _referedByTextfield.SendKeys("The Man");
            _phoneTextfield.SendKeys("123-456-7890");
            _streetTextfield.SendKeys("1 street");
            _cityTextfield.SendKeys("Portland");
            _stateDropdown.SendKeys("AK");
            _zipTextfield.SendKeys("12345");
            _investorNoRadiobutton.Click();
            _termsOfServiceCheckbox.Click();
            System.Threading.Thread.Sleep(200);
            _iUnderstandCheckbox.Click();
            System.Threading.Thread.Sleep(1000);
            _captchaCheckbox.Click();
            System.Threading.Thread.Sleep(200);
            _signUpButton.Click();
        }
    }
}