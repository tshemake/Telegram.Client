using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// <see href="https://core.telegram.org/bots/api#games">Игра</see>
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultgame"/>
    /// </summary>
    /// <remarks>
    /// Это будет работать только в версиях Telegram, выпущенных после 1 октября 2016 года.
    /// Старые клиенты не будут отображать никаких встроенных результатов, если среди них есть результат игры.
    /// </remarks>
    public class InlineQueryResultGame
    {
        /// <summary>
        /// Тип результата, должен быть «game»
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Уникальный идентификатор для этого результата.
        /// </summary>
        /// <remarks>
        /// От 1 до 64 байта
        /// </remarks>
        [Required]
        public string UniqueId { get; set; }

        /// <summary>
        /// Краткое название игры
        /// </summary>
        [Required]
        public string GameShortName { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
