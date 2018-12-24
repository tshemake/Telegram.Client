using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// Этот объект представляет собой одну кнопку клавиатуры ответа.
    /// Для простых текстовых кнопок вместо этого объекта можно использовать строку, 
    /// чтобы указать текст кнопки.
    /// </summary>
    /// <remarks>
    /// Необязательные поля являются взаимоисключающими.
    /// <see cref="RequestLocation"/> и <see cref="RequestContact"/> будут работать только в версиях Telegram, 
    /// выпущенных после 9 апреля 2016 года. Старые клиенты их игнорируют.
    /// </remarks>
    public class KeyboardButton
    {
        /// <summary>
        /// Текст кнопки.
        /// </summary>
        /// <remarks>
        /// Если ни одно из необязательных полей не используется,
        /// текст будет отправлен в виде сообщения при нажатии кнопки
        /// </remarks>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// Необязательный. Если <c>true</c>, то номер телефона пользователя будет 
        /// отправлен как контакт при нажатии кнопки.
        /// </summary>
        /// <remarks>
        /// Доступно только в «private» чатах
        /// </remarks>
        public bool RequestLocation { get; set; }

        /// <summary>
        /// Необязательный. Если <c>true</c>, то текущее местоположение пользователя
        /// будет отправлено при нажатии кнопки. 
        /// </summary>
        /// <remarks>
        /// Доступно только в «private» чатах
        /// </remarks>
        public bool RequestContact { get; set; }
    }
}
