using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Library.Types;

namespace Telegram.Client.Services
{
    using System.Threading;

    public class UpdateService : IUpdateService
    {
        private readonly IBotService _botService;

        public UpdateService(IBotService botService)
        {
            _botService = botService;
        }

        public async Task ResolveState(Update update)
        {
            if (update.Type != UpdateType.Message)
                return;

            if (update.Message.Type != MessageType.Text)
                return;

            var special = await SpecialCommandsParser(update);
            if (special)
                return;

            await SendHelp(update);
        }

        private async Task<bool> SpecialCommandsParser(Update update)
        {
            var text = GetMessageText(update);

            if (text.Contains("/start"))
            {
                var identifier = GetUserId(update);

                await _botService.Client.SendTextMessageAsync(new ChatId(identifier), "Выбор");
                return true;
            }

            if (text.Contains("/help"))
            {
                await SendHelp(update);
                return true;
            }

            if (text.Contains("/button"))
            {
                var identifier = GetUserId(update);

                await _botService.Client.SendTextMessageAsync(new ChatId(identifier), "Книопки");
                return true;
            }

            return false;
        }

        private async Task SendHelp(Update update)
        {
            var identifier = GetUserId(update);
            var helpText = "Здесь будет помощь";
            await _botService.Client.SendTextMessageAsync(new ChatId(identifier), helpText);
        }

        private long GetUserId(Update update)
        {
            return update?.CallbackQuery?.Message?.Chat.UniqueChatId ??
                   update?.Message?.Chat?.UniqueChatId ??
                   throw new Exception("UserId not exist");
        }

        private string GetNickName(Update update)
        {
            return update?.CallbackQuery?.From?.Username ??
                   update?.Message?.From?.Username ??
                   string.Empty;
        }

        private string GetMessageText(Update update)
        {
            return update?.Message?.Text ?? update?.CallbackQuery?.Message.Text;
        }
    }
}
