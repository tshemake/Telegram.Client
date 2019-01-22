using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Вариант доставки.
    /// <see href="https://core.telegram.org/bots/api#shippingoption"/>
    /// </summary>
    public class ShippingOption
    {
        public long Id { get; set; }

        /// <summary>
        /// Идентификатор варианта доставки
        /// </summary>
        [Required]
        public string Identifier { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Список цен
        /// </summary>
        public IEnumerable<LabeledPrice> Prices { get; set; }
    }
}
