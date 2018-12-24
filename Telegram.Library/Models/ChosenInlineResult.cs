using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Представляет результат <see cref="InlineQuery"/>, который был выбран <see cref="User"/> и отправлен его партнеру по чату.
    /// <see href="https://core.telegram.org/bots/api#choseninlineresult"/>
    /// </summary>
    public class ChosenInlineResult
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор выбранного результата
        /// </summary>
        [Required]
        public string ResultId { get; set; }

        /// <summary>
        /// Пользователь, который сделал выбор
        /// </summary>
        [Required]
        public User From { get; set; }

        /// <summary>
        /// Необязательный. Расположение отправителя
        /// </summary>
        /// <remarks>
        /// Только для ботов, которым требуется местоположение пользователя
        /// </remarks>
        public Location Location { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор отправленного встроенного сообщения.
        /// </summary>
        /// <remarks>
        /// Доступно, только если к сообщению прикреплена встроенная клавиатура.
        /// Также будет получен в ответных запросах и может быть использован для редактирования сообщения.
        /// </remarks>
        public string InlineMessageId { get; set; }

        /// <summary>
        /// Запрос, который был использован для получения результата
        /// </summary>
        [Required]
        public string Query { get; set; }
    }
}
