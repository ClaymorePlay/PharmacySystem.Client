﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacySystem.Client.Models
{
    public class WsResponse<T>
    {
        /// <summary>
        /// Класс откуда пришел ответ
        /// </summary>
        public string controller { get; set; }

        /// <summary>
        /// Метод
        /// </summary>
        public string method { get; set; }

        /// <summary>
        /// Ответ
        /// </summary>
        public T? value { get; set; }

        /// <summary>
        /// Сообщение об ошбке
        /// </summary>
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Код ошибки
        /// </summary>
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Успех
        /// </summary>
        public bool IsSuccess { get; set; }
    }
}
