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
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using ReadJSONusingCsharp.Models;

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
            List<test> t = new List<test>();
            t.Add(new test("profile 1", "test"));
            t.Add(new test("profile 2", "test"));
            string json = JsonConvert.SerializeObject(t);
            File.WriteAllText("profiles.json", json);
            string s = File.ReadAllText("profiles.json");
            t = JsonConvert.DeserializeObject<List<test>>(s);
            foreach(var Test in t)
            {
                Console.WriteLine(Test.name);
                Console.WriteLine(Test.Title);
            }



        }
    }

}
    