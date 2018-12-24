using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Адрес доставки.
    /// <see href="https://core.telegram.org/bots/api#shippingaddress"/>
    /// </summary>
    public class ShippingAddress
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</see> код страны
        /// </summary>
        [Required]
        public string CountryCode { get; set; }

        /// <summary>
        /// Государство, если применимо
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Город
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Первая строка адреса
        /// </summary>
        [Required]
        public string StreetLine1 { get; set; }

        /// <summary>
        /// Вторая строка адреса
        /// </summary>
        [Required]
        public string StreetLine2 { get; set; }

        /// <summary>
        /// Адрес почтовый
        /// </summary>
        [Required]
        public string PostCode { get; set; }
    }
}
