using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Информацию о входящем запросе доставки.
    /// <see href="https://core.telegram.org/bots/api#shippingquery"/>
    /// </summary>
    public class ShippingQuery
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор запроса
        /// </summary>
        [Required]
        public string UniqueIdQuery { get; set; }

        /// <summary>
        /// Пользователь, который отправил запрос
        /// </summary>
        [Required]
        public User From { get; set; }

        /// <summary>
        /// Указанный ботом счет
        /// </summary>
        [Required]
        public string InvoicePayload { get; set; }

        /// <summary>
        /// Указанный пользователем адрес доставки
        /// </summary>
        [Required]
        public ShippingAddress ShippingAddress { get; set; }
    }
}
