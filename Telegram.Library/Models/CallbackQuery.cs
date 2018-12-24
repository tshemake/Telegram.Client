using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Этот объект представляет входящий запрос обратного вызова от <see cref="InlineKeyboardButton"/> на встроенной клавиатуре.
    /// Если кнопка, отправившая запрос, была прикреплена к <see cref="Message"/>, отправленного ботом, поле сообщения будет присутствовать. 
    /// Если кнопка была прикреплена к сообщению, отправленному через бота (во встроенном режиме), поле <see cref="InlineMessageId"/> будет присутствовать.
    /// Точно будет одно из полей <see cref="Data"/> или <see cref="GameShortName"/>.
    /// <see href="https://core.telegram.org/bots/api#callbackquery"/>
    /// </summary>
    public class CallbackQuery
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
        /// Необязательный. Сообщение с кнопкой обратного вызова, инициировавшей запрос.
        /// </summary>
        /// <remarks>
        /// Обратите внимание, что содержание сообщения и дата сообщения не будут доступны, 
        /// если сообщение слишком старое
        /// </remarks>
        public Message Message { get; set; }

        /// <summary>
        /// Необязательный. Идентификатор сообщения, отправленного через бота во встроенном режиме, 
        /// с которого был отправлен запрос.
        /// </summary>
        public string InlineMessageId { get; set; }

        /// <summary>
        /// Глобальный идентификатор, однозначно соответствующий чату, 
        /// в который было отправлено сообщение с кнопкой обратного вызова.
        /// </summary>
        /// <remarks>
        /// Полезно для высоких результатов в играх.
        /// </remarks>
        [Required]
        public string ChatInstance { get; set; }

        /// <summary>
        /// Необязательный. Данные, связанные с кнопкой обратного вызова.
        /// </summary>
        /// <remarks>
        /// Помните, что плохой клиент может отправить произвольные данные в этом поле.
        /// </remarks>
        public string Data { get; set; }

        /// <summary>
        /// Необязательный. Короткое имя <see cref="Game"/>, служит уникальным идентификатором игры
        /// </summary>
        public string GameShortName { get; set; }
    }
}
