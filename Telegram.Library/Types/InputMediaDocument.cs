using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Файл для отправки.
    /// <see href="https://core.telegram.org/bots/api#inputmediadocument"/>
    /// </summary>
    public class InputMediaDocument
    {
        /// <summary>
        /// тип результата, должно быть «document»
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
        /// Необязательный. Миниатюра отправленного файла.
        /// Миниатюра должна быть в формате JPEG и размером менее 200 кБ.
        /// Ширина и высота миниатюры не должны превышать 90.
        /// Игнорируется, если файл не загружен с использованием multipart/form-data.
        /// Миниатюры не могут быть повторно использованы и могут быть загружены только как новый файл,
        /// поэтому вы можете передать «attach://<file_attach_name>», если миниатюра была загружена 
        /// с использованием multipart/form-data как <file_attach_name>.
        /// <seealso href="https://core.telegram.org/bots/api#sending-files">Подробнее об отправке файлов</seealso>
        /// </summary>
        public InputFile Thumb { get; set; }

        /// <summary>
        /// Необязательный. Заголовок документа для отправки, до 1024 символа
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
