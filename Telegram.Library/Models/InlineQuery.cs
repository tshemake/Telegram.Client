using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Этот объект представляет входящий встроенный запрос.
    /// <see href="https://core.telegram.org/bots/api#inlinequery"/>
    /// </summary>
    /// <remarks>
    /// Когда пользователь отправляет пустой запрос, ваш бот может вернуть
    /// некоторые результаты по умолчанию или трендовые результаты.
    /// </remarks>
    public class InlineQuery
    {
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор для этого запроса
        /// </summary>
        [Required]
        public string UniqueIdQuery { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        [Required]
        public User From { get; set; }

        /// <summary>
        /// Необязательный. Местоположение отправителя
        /// </summary>
        /// <remarks>
        /// Только для ботов, которые запрашивают местоположение пользователя
        /// </remarks>
        public Location Location { get; set; }

        /// <summary>
        /// Текст запроса (до 512 символов)
        /// </summary>
        [Required]
        [MaxLength(512)]
        public string Query { get; set; }

        /// <summary>
        /// Смещение результатов, которые должны быть возвращены, может контролироваться ботом
        /// </summary>
        [Required]
        public string Offset { get; set; }
    }
}
