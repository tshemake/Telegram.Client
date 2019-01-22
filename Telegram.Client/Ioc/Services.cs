using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DryIoc;
using Telegram.Client.Services;

namespace Telegram.Client.Ioc
{
    public class Services
    {
        public static void Load(IRegistrator builder)
        {
            builder.Register<IBotService, BotService>(Reuse.Singleton);
            builder.Register<IUpdateService, UpdateService>(Reuse.Scoped);
        }
    }
}
