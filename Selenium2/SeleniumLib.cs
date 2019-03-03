using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium2
{
    class SeleniumLib
    {
        //EnterText
        public static void EnterText(IWebDriver driver, string element, string value, string elementype)
        {
            if (elementype == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementype == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // Click
        public static void Click(IWebDriver driver, string element, string elementype)
        {
            if (elementype == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementype == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }

        // Selecting DropDown Control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementype)
        {
            //SelectDropDown
            if (elementype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
