using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using CefSharp.WinForms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CEFSharpSeleniumTest
{
    public partial class frmMain : Form
    {
        public IWebDriver browser;
        public void InitBrowser()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            
            chromeOptions.BinaryLocation = "C:/Users/Marc/source/repos/CEFSharpSeleniumTest/browser/bin/x86/Debug/browser.exe";                

            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;           

            browser = new ChromeDriver(driverService,chromeOptions);            
        }

        public frmMain()
        {
            InitializeComponent();
            InitBrowser();

            browser.Url = "http://www.robietherobot.com/insult-generator.htm";           

            string insult = browser.FindElement(By.CssSelector("body > table:nth-child(3) > tbody > tr > td:nth-child(3) > form > center:nth-child(3) > table > tbody > tr > td > h1")).Text;

            MessageBox.Show($"Welcome to the test app you {insult}");    

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DateTime Start;
        DateTime Finish;

        private void button1_Click(object sender, EventArgs e)
        {
            

            Start = DateTime.Now;

            browser.Url = "http://www.robietherobot.com/insult-generator.htm";

            string insult = browser.FindElement(By.CssSelector("body > table:nth-child(3) > tbody > tr > td:nth-child(3) > form > center:nth-child(3) > table > tbody > tr > td > h1")).Text;

            MessageBox.Show($"You are a {insult}");

            Finish = DateTime.Now;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            browser.Quit();
        }
    }
}
