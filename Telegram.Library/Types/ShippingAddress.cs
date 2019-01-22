using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Адрес доставки.
    /// <see href="https://core.telegram.org/bots/api#shippingaddress"/>
    /// </summary>
    public class ShippingAddress
    {
        [Key]
        [JsonIgnore]
        public long Id { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> код страны
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Государство, если применимо
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string City { get; set; }

        /// <summary>
        /// Первая строка адреса
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Вторая строка адреса
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Адрес почтовый
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public string PostCode { get; set; }
    }
}
