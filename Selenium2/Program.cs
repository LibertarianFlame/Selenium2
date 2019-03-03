using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium2
{
    [TestFixture]
    class Program
    {
        static IWebDriver driver;
        static void Main(string[] args)
        {

            /*try
            {
                Init();

                Test1();

                //CleanUp();


            }
            catch (WebDriverException e)
            {

            }*/
        }

        [SetUp]
        static public void Init()
        {
            // Создаём ссылку на браузер 
            driver = new ChromeDriver();
        }

        [Test]
        static public void Test1()
        {
            // Переходим на тестируемую страницу
            driver.Navigate().GoToUrl("https://google.com/");
            SeleniumLib.SetText(driver, "q", "Mandelbrot", PropertyType.Id);
















            // кликаем по Products
            driver.FindElement(By.XPath("//*[@id=\"main-topnav\"]/ul/li[1]/a")).Click();
            // кликаем по TestComplete
            SeleniumLib.Click(driver, "TestComplete", PropertyType.LinkText);
            // кликаем по FreeTrial
            SeleniumLib.Click(driver, "product_navigation__cta", PropertyType.ClassName);
            // вводим email 
            SeleniumLib.SetText(driver, "Email", "example@gmail.com", PropertyType.Id);
            // проверяем, что в окне правильное знаечение
            string t = SeleniumLib.GetText(driver, "Email", "Id");
            Console.WriteLine(t);
            Assert.AreEqual("example@gmail.com", t);
            // выбираем в списке стран "Russian Federation"
            SeleniumLib.SelectDropDown(driver, "Country", "Russian Federation", "Id");
            // проверяем, что выбралась Россия
            string s = SeleniumLib.GetTextFromDropdownList(driver, "Country", "Id");
            Console.WriteLine(s);

            //string s = SeleniumLib.GetText(driver, "product-cta-buttons", "ClassName");
            //Console.WriteLine(s);
        }
        [TearDown]
        static public void CleanUp()
        {
            driver.Close();
        }
    }
}