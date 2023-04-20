using System.Net.Sockets;
using System.Net.WebSockets;
using System.Threading;

namespace PharmacySystem.Client
{
    internal static class Program
    {
        public static WsConnection _wsConnection { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //_wsConnection = new WsConnection();
            //await _wsConnection.OpenConnectionAsync(CancellationToken.None);


            var client = new WsConnection();

            client.OnMessage += Client_OnMessage;
            await client.Start();

            
            WsConnection._weClient.SendAsync("", );

            Application.Run(new Form1());
        }

        private static void Client_OnMessage(object sender, string message)
        {
            throw new NotImplementedException();
        }
    }
}