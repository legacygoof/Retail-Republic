using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Security.Policy;
using System.Net.Sockets;

namespace Main_Form
{


    class CheckOut
    {
        public void EnterInformation()
        {
            String keyword = "Silk S/S Work Shirt";
            String keyword2 = "Peach";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.supremenewyork.com/shop/all/shirts";

            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                if (details.ElementAt(i).Text == keyword && details.ElementAt(i + 1).Text == keyword2)
                {
                    details.ElementAt(i).Click();
                    break;
                }
            }
            Thread.Sleep(900);
            var option = driver.FindElement(By.Id("s"));
            var selectElement = new SelectElement(option);
            selectElement.SelectByText("Large");
            // select by text
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("checkout")).Click();
            Thread.Sleep(100);


            driver.FindElement(By.Id("order_billing_name")).SendKeys("hello");
            driver.FindElement(By.Id("order_email")).SendKeys("Brandon Email");
            driver.FindElement(By.Id("order_tel")).SendKeys("8153333333");
            driver.FindElement(By.Id("bo")).SendKeys("1606 Kevin St");
            driver.FindElement(By.Id("order_billing_zip")).SendKeys("60506");
            driver.FindElement(By.Id("order_billing_city")).SendKeys("Joliet");
            var StateOption = driver.FindElement(By.Id("order_billing_state"));
            var selectState = new SelectElement(StateOption);
            selectState.SelectByText("IL");
            var CountryOption = driver.FindElement(By.Id("order_billing_country"));
            var selectCountry = new SelectElement(CountryOption);
            selectCountry.SelectByText("USA");


            driver.FindElement(By.Id("rnsnckrn")).SendKeys("123b12j4g12u4g124");
            var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
            selectMonth.SelectByText("01");
            var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
            selectYear.SelectByText("2028");
            driver.FindElement(By.Id("orcer")).SendKeys("123");
            driver.FindElement(By.ClassName("iCheck-helper")).Click();
            var check = driver.FindElement(By.Id("order_terms"));
            Actions action = new Actions(driver);
            action.MoveToElement(check).Click().Perform();
            driver.FindElement(By.Name("commit")).Click();
            // Thread.Sleep(1000);
        }
    }
}
