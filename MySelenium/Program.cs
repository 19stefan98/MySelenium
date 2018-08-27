using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MySelenium
{
    public class Program
    {
        public ChromeDriver driver;
        public string Titl { get; set; }
        public TimeSpan timeout = new TimeSpan(00, 01, 00);
        public int b { get; set; }
        public string Linkes { get; set; }
        public static void Main()
        {
            Program ro = new Program();
            ro.Start();
            ro.Element();
            //ro.Quit();
        }

        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            var Url = "https://www.yandex.ru/";
            driver.Navigate().GoToUrl(Url);
        }

        public void Element()
        {

            List<IWebElement> El = driver.FindElements(By.TagName("a")).ToList();
            foreach (IWebElement link in El)
            {

                //for (int i = 0; i < 1; i++)
                //{
                //    b += 1;
                //}
                //Console.WriteLine(b);

                //Task.Delay(4000).Wait();
                try
                {
                    var href = link.GetAttribute("href");
                    Task.Delay(3000).Wait();
                    driver.Navigate().GoToUrl(href);

                    Console.WriteLine(href);
                }
                catch
                {

                }
            }

            var a = driver.Title;
            Console.WriteLine(a);
        }

        public void Quit()
        {
            driver.Quit();
        }

    }
}