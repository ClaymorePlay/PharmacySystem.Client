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
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            ApplicationConfiguration.Initialize();
            await WsConnection.Start();

            Application.Run(new LoginForm());
            //Thread.Sleep(99999);
        }
    }
}