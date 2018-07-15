using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
//using CefSharp.WinForms;
using CefSharp.OffScreen;

namespace browser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            var settings = new CefSettings();

            settings.IgnoreCertificateErrors = true;
            settings.WindowlessRenderingEnabled = true;
            settings.DisableGpuAcceleration();

            Cef.Initialize(settings);
            var browser = new ChromiumWebBrowser("http://www.google.co.uk");

            Application.Run();
        }
    }
}
