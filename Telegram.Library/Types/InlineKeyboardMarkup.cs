using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.Library.Types
{
    /// <summary>
    /// Этот объект представляет собой <see href="https://core.telegram.org/bots#inline-keyboards-and-on-the-fly-updating">встроенную клавиатуру</see>, которая 
    /// появляется рядом с сообщением, которому оно принадлежит.
    /// <see href="https://core.telegram.org/bots/api#inlinekeyboardmarkup"/>
    /// </summary>
    /// <remarks>
    /// Это будет работать только в версиях Telegram, выпущенных после 9 апреля 2016 года.
    /// Старые клиенты Telegram будут отображать неподдерживаемое сообщение.
    /// </remarks>
    public class InlineKeyboardMarkup : IReplyMarkup
    {
        /// <summary>
        /// Массив рядов кнопок, каждый из которых представлен массивом <see cref="InlineKeyboardButton"/>.
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.Always)]
        public IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; }
    }
}
