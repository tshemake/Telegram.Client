using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Информация о счете.
    /// </summary>
    /// <see href="https://core.telegram.org/bots/api#invoice"/>
    public class Invoice
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// Наименование товара
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Описание товара
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Уникальный параметр глубокой привязки бота, который можно использовать для создания этого счета
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string StartParameter { get; set; }

        /// <summary>
        /// Трехзначный код <see href="https://core.telegram.org/bots/payments#supported-currencies">валюты</see> <see href="https://en.wikipedia.org/wiki/ISO_4217">ISO 4217</see>
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Currency { get; set; }

        /// <summary>
        /// Итоговая цена в <see href="https://core.telegram.org/bots/payments#supported-currencies">валюте</see> (целое число!).
        /// </summary>
        /// <example>
        /// Для цены 1,45 доллара США = 145.
        /// </example>
        /// <remarks>
        /// Параметр exp в <seealso href="https://core.telegram.org/bots/payments/currencies.json">currencycies.json</see>, 
        /// показывает количество цифр после запятой для каждой валюты (2 для большинства валют).
        /// </remarks>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public int TotalAmount { get; set; }
    }
}
