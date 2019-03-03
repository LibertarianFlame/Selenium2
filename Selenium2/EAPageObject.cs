using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using NUnit;

namespace Selenium2
{
    class EAPageObject
    {
        [FindsBy(How = How.LinkText, Using = "TestComplete")]
        public IWebElement urlTestComplete { get; set; }

    }
}
