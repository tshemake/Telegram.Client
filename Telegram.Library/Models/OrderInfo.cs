using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Информацию о заказе.
    /// <see href="https://core.telegram.org/bots/api#orderinfo"/>
    /// </summary>
    public class OrderInfo
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Необязательный. Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Необязательный. Номер телефона пользователя
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Необязательный. Электронная почта пользователя
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Необязательный. Адрес доставки пользователя
        /// </summary>
        public ShippingAddress ShippingAddress { get; set; }
    }
}
