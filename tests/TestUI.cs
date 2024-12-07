using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests;

public class TestUI 
{
    IWebDriver driver;
    
    [SetUp]
    public void SetUp() {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void LoginTest() {
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        IWebElement usernameInput = driver.FindElement(By.Id("user-name"));
        IWebElement passwordInput = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("login-button"));
        usernameInput.SendKeys("standard_user");
        passwordInput.SendKeys("secret_sauce");
        loginButton.Click();
        IWebElement pageTitle = driver.FindElement(By.XPath("//*[@data-test='title']"));
        Assert.That(pageTitle.Text, Is.EqualTo("Products"));    
    }

    [TearDown]
    public void TearDown() {
         driver.Quit();
    }


}