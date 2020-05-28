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
using Main_Form.Utils;

namespace Main_Form
{


    class CheckOut
    {
        public void EnterInformation()
        {
            Proxies proxy = new Proxies();
            UserInformation userInfo = new UserInformation();
            KeyWords keyWords = new KeyWords();
            CCInfo cCInfo = new CCInfo();
            String keyword = "Supreme®/The North Face® One World Tee";
            String keyword2 = "black";
            //String site = "";


            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.supremenewyork.com/shop/all/t-shirts";


            //Find product through keywords
            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                if (details.ElementAt(i).Text == keyword && details.ElementAt(i + 1).Text.ToLower() == keyword2)
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

            //Address and Personal Information input
            driver.FindElement(By.Id("order_billing_name")).SendKeys("Brandon Langys");
            driver.FindElement(By.Id("order_email")).SendKeys("Brandonlangys@gmail.com");
            driver.FindElement(By.Id("order_tel")).SendKeys("815-603-9912");
            driver.FindElement(By.Id("bo")).SendKeys("1608 Sierra Highlands Ct.");
            driver.FindElement(By.Id("order_billing_zip")).SendKeys("60586");

            //Maybe need this ----- must test
            //-----------------------------------------------------

            //driver.FindElement(By.Id("order_billing_city")).SendKeys("Joliet");
            //var StateOption = driver.FindElement(By.Id("order_billing_state"));
            //var selectState = new SelectElement(StateOption);
            //selectState.SelectByText("IL");
            //var CountryOption = driver.FindElement(By.Id("order_billing_country"));
            //var selectCountry = new SelectElement(CountryOption);
            //selectCountry.SelectByText("USA");

            //--------------------------------------------------------------

            /// Credit card information inputs
            driver.FindElement(By.Id("rnsnckrn")).SendKeys("516854416011005149072533");
            var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
            selectMonth.SelectByText("09");
            var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
            selectYear.SelectByText("2024");
            driver.FindElement(By.Id("orcer")).SendKeys("964");
            driver.FindElement(By.ClassName("iCheck-helper")).Click();
            var check = driver.FindElement(By.Id("order_terms"));
            Actions action = new Actions(driver);
            action.MoveToElement(check).Click().Perform();
            Thread.Sleep(3000);
            driver.FindElement(By.Name("commit")).Click();
            // Thread.Sleep(1000);

        }
    }
}
