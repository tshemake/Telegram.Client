using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Одна из кнопок встроенной клавиатуры.
    /// <see href="https://core.telegram.org/bots/api#inlinekeyboardbutton"/>
    /// </summary>
    /// <remarks>
    /// Вы должны использовать только одно из необязательных полей.
    /// </remarks>
    public class InlineKeyboardButton
    {
        /// <summary>
        /// Текст на кнопке
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. HTTP или tg:// URL, который открывается при нажатии кнопки
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Необязательный. Данные, которые будут отправлены в запросе <see cref="CallbackQuery"/> боту при нажатии кнопки, размером с 1 до 64 байта
        /// </summary>
        public string CallbackData { get; set; }

        /// <summary>
        /// Необязательный. Если установлено, то нажатие кнопки предложит пользователю 
        /// выбрать один из своих чатов, открыть этот чат и вставить username бота и 
        /// указанный встроенный запрос в поле ввода.
        /// Может быть пустым, в этом случае будет добавлено только username бота.
        /// </summary>
        /// <remarks>
        /// Это дает пользователям простой способ начать использовать своего бота во <see href="https://core.telegram.org/bots/inline">«inline» режиме</see>,
        /// когда они в данный момент находятся в «private» чате с ним.
        /// </remarks>
        public string SwitchInlineQuery { get; set; }

        /// <summary>
        /// Необязательный. Если установлен, то нажатие кнопки вставит username бота и 
        /// указанный встроенный запрос в поле ввода текущего чата.
        /// Может быть пустым, в этом случае будет добавлено только username бота.
        /// </summary>
        /// <remarks>
        /// Это позволяет пользователю быстро открыть своего бота во <see href="https://core.telegram.org/bots/inline">«inline» режиме</see> 
        /// в одном чате - хорошо для выбора чего-либо из нескольких вариантов.
        /// </remarks>
        public string SwitchInlineQueryCurrentChat { get; set; }

        /// <summary>
        /// Необязательный. Описание игры, которая будет запущена, когда пользователь нажимает кнопку.
        /// </summary>
        /// <remarks>
        /// Кнопка этого типа всегда должна быть первой кнопкой в первом ряду.
        /// </remarks>
        public CallbackGame CallbackGame { get; set; }

        /// <summary>
        /// Необязательный. Укажите <c>true</c>, чтобы отправить <see href="https://core.telegram.org/bots/api#payments">кнопку оплаты</see>.
        /// </summary>
        /// <remarks>
        /// Этот тип кнопки всегда должен быть первой кнопкой в первом ряду.
        /// </remarks>
        public bool Pay { get; set; }
    }
}
