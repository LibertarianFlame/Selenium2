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
    enum PropertyType
    {
        Id,
        Name,
        ClassName,
        LinkText,
        CssName,
        XPath
    }
    class SeleniumLib
    {

        //EnterText
        public static void SetText(IWebDriver driver, string element, string value, PropertyType elementype)
        {
            if (elementype == PropertyType.Id)
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementype == PropertyType.Name)
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
            if (elementype == PropertyType.ClassName)
            {
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            }
            if (elementype == PropertyType.LinkText)
            {
                driver.FindElement(By.LinkText(element)).SendKeys(value);
            }
            if (elementype == PropertyType.CssName)
            {
                driver.FindElement(By.CssSelector(element)).SendKeys(value);
            }
            if (elementype == PropertyType.XPath)
            {
                driver.FindElement(By.XPath(element)).SendKeys(value);
            }
        }

        // Click
        public static void Click(IWebDriver driver, string element, PropertyType elementype)
        {
            if (elementype == PropertyType.Id)
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementype == PropertyType.Name)
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementype == PropertyType.ClassName)
            {
                driver.FindElement(By.ClassName(element)).Click();
            }
            if (elementype == PropertyType.LinkText)
            {
                driver.FindElement(By.LinkText(element)).Click();
            }
            if (elementype == PropertyType.CssName)
            {
                driver.FindElement(By.CssSelector(element)).Click();
            }
            if (elementype == PropertyType.XPath)
            {
                driver.FindElement(By.XPath(element)).Click();
            }
        }

        // Selecting DropDown Control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementype)
        {
            if (elementype == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementype == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }
            if (elementype == "ClassName")
            {
                new SelectElement(driver.FindElement(By.ClassName(element))).SelectByValue(value);
            }
            if (elementype == "LinkText")
            {
                new SelectElement(driver.FindElement(By.LinkText(element))).SelectByValue(value);
            }
        }

        public static string GetText(IWebDriver driver, string element, string elementype)
        {
            if (elementype == "Id")
            {
                return driver.FindElement(By.Id(element)).GetAttribute("value");
            }
            if (elementype == "Name")
            {
                return driver.FindElement(By.Name(element)).GetAttribute("value");
            }
            if (elementype == "ClassName")
            {
                return driver.FindElement(By.ClassName(element)).GetAttribute("value");
            }

            return String.Empty;
        }

        public static string GetTextFromDropdownList(IWebDriver driver, string element, string elementype)
        {
            if (elementype == "Id")
            {
                return new SelectElement(driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementype == "Name")
            {
                return new SelectElement(driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            }
            if (elementype == "ClassName")
            {
                return new SelectElement(driver.FindElement(By.ClassName(element))).AllSelectedOptions.SingleOrDefault().Text;
            }

            return String.Empty;
        }
    }
}
