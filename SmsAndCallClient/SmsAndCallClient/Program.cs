using System;
using System.Windows.Forms;
using Twilio.TwiML;

namespace MatthiWare.SmsAndCallClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine(new VoiceResponse().Say("{body}", language: "en", voice: "alice").Hangup());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
