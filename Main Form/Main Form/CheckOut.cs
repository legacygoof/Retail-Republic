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
            UserInformation userInfo = new UserInformation();
            KeyWords keyWords = new KeyWords();
            CCInfo cCInfo = new CCInfo();
            String keyword = "Silk S/S Work Shirt";
            String keyword2 = "Peach";
            String site = "";

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.supremenewyork.com/shop/all/"+site;


            //Find product through keywords
            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                if (details.ElementAt(i).Text == keyWords.KeyWord1 && details.ElementAt(i + 1).Text == keyWords.KeyWord2)
                {
                    details.ElementAt(i).Click();
                    break;
                }
            }
            Thread.Sleep(900);
            var option = driver.FindElement(By.Id("s"));
            var selectElement = new SelectElement(option);
            selectElement.SelectByText(keyWords.ItemSize);
            // select by text
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("checkout")).Click();
            Thread.Sleep(100);

            //Address and Personal Information input
            driver.FindElement(By.Id("order_billing_name")).SendKeys(userInfo.FName + " " + userInfo.LName);
            driver.FindElement(By.Id("order_email")).SendKeys(userInfo.Email);
            driver.FindElement(By.Id("order_tel")).SendKeys(userInfo.TelNumber);
            driver.FindElement(By.Id("bo")).SendKeys(userInfo.Address);
            driver.FindElement(By.Id("order_billing_zip")).SendKeys(userInfo.ZipCode);

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
            driver.FindElement(By.Id("rnsnckrn")).SendKeys(cCInfo.CCNumber);
            var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
            selectMonth.SelectByText(cCInfo.CCExpMonth);
            var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
            selectYear.SelectByText(cCInfo.CCExpYear);
            driver.FindElement(By.Id("orcer")).SendKeys(cCInfo.CCCsv);
            driver.FindElement(By.ClassName("iCheck-helper")).Click();
            var check = driver.FindElement(By.Id("order_terms"));
            Actions action = new Actions(driver);
            action.MoveToElement(check).Click().Perform();
            driver.FindElement(By.Name("commit")).Click();
            // Thread.Sleep(1000);
        }
    }
}
