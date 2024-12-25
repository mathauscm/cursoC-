using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class Program
{
    static void Main(string[] args)
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");
        options.AddArgument("--disable-infobars");
        options.AddArgument("--disable-extensions");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--disable-dev-shm-usage");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-setuid-sandbox");

        IWebDriver driver = new ChromeDriver(options);

        try
        {
            driver.Navigate().GoToUrl("https://www.realestate.com.au/sa/adelaide-5000/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementExists(By.TagName("body")));
            Console.WriteLine("Página carregada com sucesso!");

            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("page_loaded.png", ScreenshotImageFormat.Png);

            Thread.Sleep(60000); // Manter a página aberta por 1 minuto (60 segundos)
        }
        catch (Exception e)
        {
            Console.WriteLine("Erro ao carregar a página: " + e.Message);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile("error_loading_page.png", ScreenshotImageFormat.Png);
        }
        finally
        {
            driver.Quit();
        }
    }
}