using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Telegram.Library.Models
{
    /// <summary>
    /// После получения сообщения с этим объектом Telegram клинеты удаляют текущую пользовательскую клавиатуру
    /// и отображают буквенную клавиатуру по умолчанию.
    /// <see href="https://core.telegram.org/bots/api#replykeyboardremove"/>
    /// </summary>
    /// <remarks>
    /// По умолчанию пользовательские клавиатуры отображаются до тех пор, пока бот не отправит новую клавиатуру.
    /// Исключение делается для одноразовых клавиатур, которые скрываются сразу после нажатия пользователем кнопки (<see cref="ReplyKeyboardMarkup"/>).
    /// </remarks>
    public class ReplyKeyboardRemove
    {
        /// <summary>
        /// Просит клиентов удалить пользовательскую клавиатуру (пользователь не сможет вызвать эту клавиатуру; 
        /// если вы хотите скрыть клавиатуру от глаз, но оставить ее доступной, используйте <see cref="ReplyKeyboardMarkup.OneTimeKeyboard"/>)
        /// </summary>
        [Required]
        public bool RemoveKeyboard => true;

        /// <summary>
        /// Необязательный. Используйте этот параметр, если вы хотите удалить клавиатуру только для определенных пользователей.
        /// Цели:
        ///     1) пользователи, которые упоминаются в тексте объекта <see cref="Message"/>;
        ///     2) если сообщение бота является ответом (имеет <see cref="Message.ReplyToMessage"/>), исходного сообщения.
        /// </summary>
        /// <example>
        /// Пример: пользователь голосует в опросе, бот возвращает ответное сообщение в ответ на голосование 
        /// и удаляет клавиатуру для этого пользователя, в то же время показывая клавиатуру с
        /// параметрами опроса пользователям, которые еще не проголосовали.
        /// </example>
        public bool Selective { get; set; }
    }
}
