using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Информация об успешном платеже.
    /// <see href="https://core.telegram.org/bots/api#successfulpayment"/>
    /// </summary>
    public class SuccessfulPayment
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

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

        /// <summary>
        /// Указанный ботом счет
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string InvoicePayload { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор варианта доставки, выбранного пользователем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShippingOptionId { get; set; }

        /// <summary>
        /// Необязательный. Информация о заказе, предоставленная пользователем
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo OrderInfo { get; set; }

        /// <summary>
        /// Идентификатор платежа Telegram
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string TelegramPaymentChargeId { get; set; }

        /// <summary>
        /// Идентификатор платежа провайдера
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string ProviderPaymentChargeId { get; set; }
    }
}
