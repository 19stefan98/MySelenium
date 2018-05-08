using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace MySelenium
{
    public class Program
    {
        public IWebDriver driver;
        TimeSpan timeuot = new TimeSpan(00, 01, 00);

        public static void Main()
        {
            Program ro = new Program();
            ro.Start();
            ro.Quit();
        }

        public void Start()
        {
            driver = new ChromeDriver();
            TimeSpan timeout = new TimeSpan(00, 00, 30);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://tairai.itech-test.ru/");
        }

        public void Quit()
        {
            driver.Quit();
        }

        public void Size()
        {
            int size = new IWindow.size(1900, 1380);
        }
    }
}
