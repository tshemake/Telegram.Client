using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// <see href="https://core.telegram.org/bots/api#inputmessagecontent">Содержимое</see> текстового сообщения, которое будет отправлено 
    /// в результате встроенного запроса.
    /// <see href="https://core.telegram.org/bots/api#inputtextmessagecontent"/>
    /// </summary>
    public class InputTextMessageContent : InputMessageContent
    {
        /// <summary>
        /// Текст сообщения для отправки, от 1 до 4096 символов
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(4096)]
        public string MessageText { get; private set; }

        /// <summary>
        /// Необязательный. Отправьте <see href="https://core.telegram.org/bots/api#markdown-style">Markdown</see> или <see href="https://core.telegram.org/bots/api#html-style">HTML</see>, если вы хотите 
        /// чтобы приложения Telegram отображали
        /// <see href="https://core.telegram.org/bots/api#formatting-options">жирный шрифт, курсив, текст фиксированной ширины или встроенные URL-адреса</see> в заголовке мультимедиа.
        /// </summary>
        public ParseMode ParseMode { get; set; }

        /// <summary>
        /// Необязательный. Отключает предварительный просмотр ссылок в отправленном сообщении
        /// </summary>
        public bool DisableWebPagePreview { get; set; }
    }
}
