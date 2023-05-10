using Newtonsoft.Json;
using PharmacySystem.Client.Models;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;

namespace PharmacySystem.Client
{
    public static class Program
    {
        public static MainForm? _mainForm { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();


            var resp = await WsConnection.Start();
            if(resp != null)
                Application.Run(resp);

            
            //Thread.Sleep(99999);
        }
    }
}