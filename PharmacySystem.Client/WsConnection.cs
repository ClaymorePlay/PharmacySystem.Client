using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.Client
{
    public class WsConnection
    {
        public static ClientWebSocket _weClient { get; set; }

        // Declare the delegate (if using non-generic pattern).
        public delegate void SocketEventHandler(object sender, string message);

        public event SocketEventHandler OnMessage;

        public async Task Start()
        {
            using var ws = new ClientWebSocket();

            await ws.ConnectAsync(new Uri($"wss://localhost:44356/ws?token={Guid.NewGuid()}"), CancellationToken.None);
            byte[] buf = new byte[4056];

            while (ws.State == WebSocketState.Open)
            {
                var result = await ws.ReceiveAsync(buf, CancellationToken.None);

                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, null, CancellationToken.None);
                }
                else
                {
                    OnMessage.Invoke(this, Encoding.ASCII.GetString(buf, 0, result.Count));
                }
            }
        }
    }
}
