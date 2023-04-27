﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PharmacySystem.Client.Models;
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
    public static class WsConnection
    {
        public static ClientWebSocket _weClient = new ClientWebSocket();

        /// <summary>
        /// Запуск соединения
        /// </summary>
        /// <returns></returns>
        public static async Task Start()
        {
            try
            {
                var token = await GetToken();

                Uri endpointUri = new Uri($"wss://localhost:44356/ws?token={token ?? Guid.NewGuid().ToString()}");

                _weClient.Options.KeepAliveInterval = TimeSpan.FromSeconds(120);
                await _weClient.ConnectAsync(endpointUri, CancellationToken.None);
            }
            catch (Exception ex)
            {

            }
        }

        /// <summary>
        /// Отправка и получение сообщения
        /// </summary>
        /// <returns></returns>
        public static async Task<WsResponse<T>> SendAndWaitResponse<T>(object? request)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(request));
                await _weClient.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);

                byte[] receiveBuffer = new byte[1024 * 4];

                WebSocketReceiveResult result = await _weClient.ReceiveAsync(new ArraySegment<byte>(receiveBuffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                    await _weClient.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, new CancellationTokenSource(TimeSpan.FromSeconds(30)).Token);

                var r = Encoding.UTF8.GetString(receiveBuffer);
                return JsonConvert.DeserializeObject<WsResponse<T>>(Encoding.UTF8.GetString(receiveBuffer));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Сохранение токена
        /// </summary>
        /// <returns></returns>
        private static async Task<bool> SaveToken(Guid token)
        {
            //if (File.Exists("./token.txt"))
                await File.WriteAllTextAsync("./token.txt", token.ToString());


            return true;
        }

        /// <summary>
        /// Получение токена
        /// </summary>
        /// <returns></returns>
        private static async Task<string?> GetToken()
        {
            if (File.Exists("./token.txt"))
            {
                var text = await File.ReadAllTextAsync("./token.txt");
                return text;
            }
            return null;
        }
    }
}
