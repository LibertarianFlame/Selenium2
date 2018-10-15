using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium2
{
    class Program
    {
        static IWebDriver driver;
        static void Main(string[] args)
        {

            try
            {
                Init();

                Test1();

                //CleanUp();


            }
            catch (WebDriverException e)
            {

            }
        }

        static void Init()
        {
            // Создаём ссылку на браузер
            driver = new ChromeDriver();
        }

        static void Test1()
        {
            // Переходим на тестируемую страницу
            driver.Navigate().GoToUrl("https://smartbear.com/");
            // PhraseToSearch
            //SeleniumLib.EnterText(driver, "PhraseToSearch", "TestComplete", "Id");
            //SeleniumLib.EnterText(driver, "PhraseToSearch", Keys.Enter, "Id");

            // //*[@id="main-topnav"]/ul/li[1]/a
            driver.FindElement(By.XPath("//*[@id=\"main-topnav\"]/ul/li[1]/a")).Click();
        }

        static void CleanUp()
        {
            driver.Close();
        }
    }
}
