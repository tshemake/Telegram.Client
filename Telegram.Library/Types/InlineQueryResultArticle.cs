using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Ссылка на статью или веб-страницу.
    /// <see href="https://core.telegram.org/bots/api#inlinequeryresultarticle"/>
    /// </summary>
    public class InlineQueryResultArticle
    {
        /// <summary>
        /// Тип результата, должен быть «article»
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
        /// Название результата
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Содержание сообщения для отправки
        /// </summary>
        [Required]
        public InputMessageContent InputMessageContent { get; set; }

        /// <summary>
        /// Необязательный. <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">Встроенная клавиатура</see> прикрепленая к сообщению
        /// </summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>
        /// Необязательный. URL результата
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Необязательный. Передайте <c>true</c>, если вы не хотите, чтобы URL отображался в сообщении
        /// </summary>
        public bool HideUrl { get; set; }

        /// <summary>
        /// Необязательный. Краткое описание результата
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Необязательный. URL миниатюры для результата
        /// </summary>
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Необязательный. Ширина миниатюры
        /// </summary>
        public int ThumbWidth { get; set; }

        /// <summary>
        /// Необязательный. Высота миниатюры
        /// </summary>
        public int ThumbHeight { get; set; }
    }
}
