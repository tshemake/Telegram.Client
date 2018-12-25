using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Фотография для отправки.
    /// <see href="https://core.telegram.org/bots/api#inputmediaphoto"/>
    /// </summary>
    public class InputMediaPhoto
    {
        /// <summary>
        /// Тип результата, должно быть «photo»
        /// </summary>
        [Required]
        public string Type { get; set; }

        /// <summary>
        /// Файл для отправки. 
        /// Передайте file_id, чтобы отправить файл, который существует
        /// на серверах Telegram (рекомендуется), передайте HTTP URL для Telegram,
        /// чтобы получить файл из Интернета, или передайте «attach://<file_attach_name>»,
        /// чтобы загрузить новый, используя multipart/form-data под именем <file_attach_name>.
        /// <seealso href="https://core.telegram.org/bots/api#sending-files">Подробнее об отправке файлов</seealso>
        /// </summary>
        [Required]
        public string Media { get; set; }

        /// <summary>
        /// Необязательный. Заголовок фотографии для отправки, до 1024 символа
        /// </summary>
        [MaxLength(1024)]
        public string Caption { get; set; }

        /// <summary>
        /// Необязательный. Отправьте <see href="https://core.telegram.org/bots/api#markdown-style">Markdown</see> или <see href="https://core.telegram.org/bots/api#html-style">HTML</see>, если вы хотите 
        /// чтобы приложения Telegram отображали
        /// <see href="https://core.telegram.org/bots/api#formatting-options">жирный шрифт, курсив, текст фиксированной ширины или встроенные URL-адреса</see> в заголовке мультимедиа.
        /// </summary>
        public ParseMode ParseMode { get; set; }
    }
}
