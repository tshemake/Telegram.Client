using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Пользовательская клавиатура с параметрами ответа
    /// <see href="https://core.telegram.org/bots/api#replykeyboardmarkup"/>
    /// </summary>
    /// <remarks>
    /// <see cref="">Подробности и примеры смотреть в разделе <see href="https://core.telegram.org/bots#keyboards">Введение в ботов</see></see>
    /// </remarks>
    class ReplyKeyboardMarkup
    {
        /// <summary>
        /// Массив строк кнопок, каждый из которых представлен массивом объектов KeyboardButton
        /// </summary>
        [Required]
        public IEnumerable<IEnumerable<KeyboardButton>> Keyboard { get; set; }

        /// <summary>
        /// Необязательный. Просит клиентов изменить размер клавиатуры по вертикали для оптимального размера
        /// (например, сделать клавиатуру меньше, если есть только два ряда кнопок).
        /// </summary>
        /// <remarks>
        /// По умолчанию значение <c>false</c>, и в этом случае настраиваемая клавиатура всегда имеет ту же высоту, 
        /// что и стандартная клавиатура приложения.
        /// </remarks>
        public bool ResizeKeyboard { get; set; }

        /// <summary>
        /// Необязательный. Просит клиентов спрятать клавиатуру, как только она будет использована.
        /// Клавиатура по-прежнему будет доступна, но клиенты будут автоматически отображать обычную
        /// буквенную клавиатуру в чате - пользователь может нажать специальную кнопку в поле ввода,
        /// чтобы снова увидеть пользовательскую клавиатуру.
        /// </summary>
        /// <remarks>
        /// По умолчанию значение <c>false</c>.
        /// </remarks>
        public bool OneTimeKeyboard { get; set; }

        /// <summary>
        /// Необязательный. Используйте этот параметр, если вы хотите показывать клавиатуру только определенным пользователям.
        /// Цели:
        ///     1) пользователи, которые упоминаются в тексте объекта <see cref="Message"/>;
        ///     2) если сообщение бота является ответом (имеет <see cref="Message.ReplyToMessage"/>), исходного сообщения.
        /// </summary>
        /// <example>
        /// Пользователь просит изменить язык бота, бот отвечает на запрос с помощью клавиатуры,
        /// предлогая выбрать новый язык. Другие пользователи в группе не видят клавиатуру.
        /// </example>
        public bool Selective { get; set; }
    }
}
