using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Library.Types;

namespace Telegram.Client.Services
{
    public interface IUpdateService
    {
        Task ResolveState(Update update);
    }
}
