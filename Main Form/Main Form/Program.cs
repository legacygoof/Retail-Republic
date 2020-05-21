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
using System.Drawing.Text;
using Main_Form.Utils;

namespace Main_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Proxies proxy = new Proxies();
            //Application.Run(new Login());
            //Application.Run(new Add_Task());
            //Application.Run(new Retail_Republic());
            //CheckOut checkOut = new CheckOut();
            //checkOut.EnterInformation();
            var cService = ChromeDriverService.CreateDefaultService();
            cService.HideCommandPromptWindow = true;

            var options = new ChromeOptions();

            options.AddArguments("--proxy-server=" + proxy.IP + ":" + proxy.port);
            //options.AddExtension(@"C:\My Folder\ProxyChanger.crx");

            options.Proxy = null;

            //string userAgent = "<< User Agent Text >>";

            //options.AddArgument($"--user-agent={userAgent}$PC${"<< User Name >>" + ":" + "<< Password >>"}");

            IWebDriver _webDriver = new ChromeDriver(cService, options);

            _webDriver.Navigate().GoToUrl("https://whatismyipaddress.com/");


        }
    }

}
    