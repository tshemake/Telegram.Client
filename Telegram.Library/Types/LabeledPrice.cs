using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет часть цены на товары или услуги.
    /// </summary>
    /// <see href="https://core.telegram.org/bots/api#labeledprice"/>
    public class LabeledPrice
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Лейбел
        /// </summary>
        [Required]
        public string Label { get; set; }

        /// <summary>
        /// Цена продукта в <see href="https://core.telegram.org/bots/payments#supported-currencies">валюте</see> (целое число!).
        /// </summary>
        /// <example>
        /// Для цены 1,45 доллара США = 145.
        /// </example>
        /// <remarks>
        /// Параметр exp в <seealso href="https://core.telegram.org/bots/payments/currencies.json">currencycies.json</see>, 
        /// показывает количество цифр после запятой для каждой валюты (2 для большинства валют).
        /// </remarks>
        [Required]
        public int Amount { get; set; }
    }
}
