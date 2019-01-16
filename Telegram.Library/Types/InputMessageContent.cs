using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет содержание сообщения, 
    /// которое будет отправлено в результате встроенного запроса.
    /// <see href="https://core.telegram.org/bots/api#inputmessagecontent"/>
    /// </summary>
    /// <remarks>
    /// В настоящее время клиенты Telegram поддерживают следующие 4 типа:
    ///     - <see cref="InputTextMessageContent"/>
    ///     - <see cref="InputLocationMessageContent"/>
    ///     - <see cref="InputVenueMessageContent"/>
    ///     - <see cref="InputContactMessageContent"/>
    /// </remarks>
    public abstract class InputMessageContent
    {
    }
}
