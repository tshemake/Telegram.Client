using System;
using System.Collections.Generic;
using System.Text;

namespace Telegram.Library.Requests
{
    /// <summary>
    /// Простой метод для проверки токена авторизации вашего бота.
    /// Не требует никаких параметров.
    /// Возвращает основную информацию о боте в виде объекта <see cref="Models.User"/>.
    /// </summary>
    public class GetMeRequest : ParameterlessRequest
    {
        public GetMeRequest()
            : base("getMe")
        { }
    }
}
