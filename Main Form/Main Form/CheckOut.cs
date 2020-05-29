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
        bool itemFound = false;
        bool sizeFound = false;
        bool colorFound = false;
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
            //var option = driver.FindElement(By.Id("s"));
            //var selectElement = new SelectElement(option);
            //selectElement.SelectByText(keyWords.ItemSize);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="site"></param>
        /// <param name="cat"></param>
        /// <param name="color"></param>
        /// <param name="size"></param>
        /// <param name="p"></param>
        public void EnterInformation(string site, string cat, string color, string size, Profile p)
        {
            //https://www.supremenewyork.com/shop/all/t-shirts
            //Supreme®/The North Face® 
            //Black
            UserInformation userInfo = new UserInformation();
            KeyWords keyWords = new KeyWords();
            CCInfo cCInfo = new CCInfo();
            //keyword = "Silk S/S Work Shirt";
            //keyword2 = "Peach";
            //String site = "";  https://www.supremenewyork.com/shop/all/accessories
            // MessageBox.Show("Called\n" +keyword + "\n" +keyword2);
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = site;


            //Find product through keywords
            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                //if (details.ElementAt(i).Text == "Beaded Keychain" && details.ElementAt(i + 1).Text == keyword2)
                if (details.ElementAt(i).Text.Equals("Supreme®/The North Face® \n" + Environment.NewLine +
                    "Floating Keychain"))//Contains("Floating Keychain"))
                //if(details.ElementAt(i).Text.Contains("Floating Keychain") && details.ElementAt(i+1).Text.Equals("Black"))
                {
                    details.ElementAt(i).Click();
                    //MessageBox.Show("CLICKED");
                    MessageBox.Show(details.ElementAt(i).Text);
                    break;
                }
            }
            Thread.Sleep(900);
            //var option = driver.FindElement(By.Id("s"));
            //var selectElement = new SelectElement(option);
            //selectElement.SelectByText("Medium");
            // select by text
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("checkout")).Click();
            Thread.Sleep(100);

            //Address and Personal Information input
            driver.FindElement(By.Id("order_billing_name")).SendKeys("Kevin Hansen");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("order_email")).SendKeys("7kphans@gmail.com");
            driver.FindElement(By.Id("order_tel")).SendKeys("8159097982");
            driver.FindElement(By.Id("bo")).SendKeys("2301 Park Ridge Drive");
            Thread.Sleep(2000);
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
            Thread.Sleep(1000);
            driver.FindElement(By.Id("rnsnckrn")).SendKeys("5217300201789825");
            var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
            selectMonth.SelectByText("03");
            var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
            Thread.Sleep(1000);
            selectYear.SelectByText("2022");
            driver.FindElement(By.Id("orcer")).SendKeys("540");
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("iCheck-helper")).Click();
            var check = driver.FindElement(By.Id("order_terms"));

            Actions action = new Actions(driver);
            action.MoveToElement(check).Click().Perform();
            driver.FindElement(By.Name("commit")).Click();
        }




        public void EnterInformation(List<TaskInfo> ti, int loc)
        {
            ti[loc].status = "Running!";
            //https://www.supremenewyork.com/shop/all/t-shirts
            //Supreme®/The North Face® 
            //Black
            UserInformation userInfo = new UserInformation();
            KeyWords keyWords = new KeyWords();
            CCInfo cCInfo = new CCInfo();
            //keyword = "Silk S/S Work Shirt";
            //keyword2 = "Peach";
            //String site = "";  https://www.supremenewyork.com/shop/all/accessories
            // MessageBox.Show("Called\n" +keyword + "\n" +keyword2);

            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ti[loc].site;


            //Find product through keywords
            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                //if (details.ElementAt(i).Text == "Beaded Keychain" && details.ElementAt(i + 1).Text == keyword2)
                string product = "";
                for(int j = 0; j < ti[loc].Keywords.Count; j++)
                {
                    if(j != ti[loc].Keywords.Count)
                        product += ti[loc].Keywords[j] + " ";
                    else
                    product += ti[loc].Keywords[j];
                }
                //MessageBox.Show(ti[loc].Keywords[0].ToLower());
                if (details.ElementAt(i).Text.ToLower().Contains(ti[loc].Keywords[0].ToLower()) && details.ElementAt(i + 1).Text.ToLower() == ti[loc].color.ToLower())//Contains("Floating Keychain"))
                //if(details.ElementAt(i).Text.Contains("Floating Keychain") && details.ElementAt(i+1).Text.Equals("Black"))
                {
                    details.ElementAt(i).Click();
                   // MessageBox.Show("CLICKED");
                    //MessageBox.Show(details.ElementAt(i).Text);
                    itemFound = true;
                    break;
                }
            }
            Thread.Sleep(900);
            if (itemFound)
            {
                try
                {
                    var option = driver.FindElement(By.Id("s"));
                    var selectElement = new SelectElement(option);
                    selectElement.SelectByText("s/m");
                    sizeFound = true;
                }
                catch (Exception e)
                {
                    
                    ti[loc].status = "Failed - Sold Out";
                    return;
                }
                
            }
            else {  ti[loc].status = "Failed - Item Not Found"; return; }
            // select by text
            try
            {
                driver.FindElement(By.Name("commit")).Click();
                ti[loc].status = "Added To Cart";
                Thread.Sleep(2000);
            }
            catch (Exception e)
            {
                ti[loc].status = "Failed - Sold Out";
            }

            try
            {
                driver.FindElement(By.ClassName("checkout")).Click();
                ti[loc].status = "Checking Out";
                Thread.Sleep(100);
            }
            catch(Exception e)
            {
                ti[loc].status = "Failed - Out Of Stock";
            }



            //Address and Personal Information input
            try
            {
                driver.FindElement(By.Id("order_billing_name")).SendKeys(ti[loc].profile.uInfo.FName + " " + ti[loc].profile.uInfo.LName);
                Thread.Sleep(1000);
                driver.FindElement(By.Id("order_email")).SendKeys(ti[loc].profile.uInfo.Email);
                driver.FindElement(By.Id("order_tel")).SendKeys(ti[loc].profile.uInfo.TelNumber);
                driver.FindElement(By.Id("bo")).SendKeys(ti[loc].profile.uInfo.Address);
                Thread.Sleep(2000);
                driver.FindElement(By.Id("order_billing_zip")).SendKeys(ti[loc].profile.uInfo.ZipCode);

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
                Thread.Sleep(1000);
                driver.FindElement(By.Id("rnsnckrn")).SendKeys(ti[loc].profile.CC.CCNumber);
                var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
                selectMonth.SelectByText(ti[loc].profile.CC.CCExpMonth);
                var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
                Thread.Sleep(1000);
                selectYear.SelectByText(ti[loc].profile.CC.CCExpYear);
                driver.FindElement(By.Id("orcer")).SendKeys(ti[loc].profile.CC.CCCsv);
                Thread.Sleep(1000);
                driver.FindElement(By.ClassName("iCheck-helper")).Click();
                var check = driver.FindElement(By.Id("order_terms"));

                Actions action = new Actions(driver);
                action.MoveToElement(check).Click().Perform();
                driver.FindElement(By.Name("commit")).Click();
            }
            catch (Exception e)
            {
                ti[loc].status = "Failed - Sold Out";
            }
            // Thread.Sleep(1000);
        }

        public void EnterInformation(string site, string keyword, string keyword2)
            {
            //https://www.supremenewyork.com/shop/all/t-shirts
            //Supreme®/The North Face® 
            //Black
            UserInformation userInfo = new UserInformation();
            KeyWords keyWords = new KeyWords();
            CCInfo cCInfo = new CCInfo();
            //keyword = "Silk S/S Work Shirt";
            //keyword2 = "Peach";
            //String site = "";  https://www.supremenewyork.com/shop/all/accessories
            // MessageBox.Show("Called\n" +keyword + "\n" +keyword2);
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = site;


            //Find product through keywords
            IList<IWebElement> details = driver.FindElements(By.ClassName("name-link"));

            int count = details.Count();

            for (int i = 0; i < count; i++)
            {
                //if (details.ElementAt(i).Text == "Beaded Keychain" && details.ElementAt(i + 1).Text == keyword2)
                if (details.ElementAt(i).Text.Equals("Supreme®/The North Face® \n" + Environment.NewLine + 
                    "Floating Keychain"))//Contains("Floating Keychain"))
                //if(details.ElementAt(i).Text.Contains("Floating Keychain") && details.ElementAt(i+1).Text.Equals("Black"))
                {
                    details.ElementAt(i).Click();
                    //MessageBox.Show("CLICKED");
                    MessageBox.Show(details.ElementAt(i).Text);
                    break;
                }
            }
            Thread.Sleep(900);
            //var option = driver.FindElement(By.Id("s"));
            //var selectElement = new SelectElement(option);
            //selectElement.SelectByText("Medium");
            // select by text
            driver.FindElement(By.Name("commit")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("checkout")).Click();
            Thread.Sleep(100);

            //Address and Personal Information input
            driver.FindElement(By.Id("order_billing_name")).SendKeys("Kevin Hansen");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("order_email")).SendKeys("7kphans@gmail.com");
            driver.FindElement(By.Id("order_tel")).SendKeys("8159097982");
            driver.FindElement(By.Id("bo")).SendKeys("2301 Park Ridge Drive");
            Thread.Sleep(2000);
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
             Thread.Sleep(1000);
            driver.FindElement(By.Id("rnsnckrn")).SendKeys("5217300201789825");
            var selectMonth = new SelectElement(driver.FindElement(By.Id("credit_card_month")));
            selectMonth.SelectByText("03");
            var selectYear = new SelectElement(driver.FindElement(By.Id("credit_card_year")));
            Thread.Sleep(1000);
            selectYear.SelectByText("2022");
            driver.FindElement(By.Id("orcer")).SendKeys("540");
            Thread.Sleep(1000);
            driver.FindElement(By.ClassName("iCheck-helper")).Click();
            var check = driver.FindElement(By.Id("order_terms"));
            
            Actions action = new Actions(driver);
            action.MoveToElement(check).Click().Perform();
            driver.FindElement(By.Name("commit")).Click();
            // Thread.Sleep(1000);
        }
    }
}
