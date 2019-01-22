using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Telegram.Client.Services;
using Telegram.Library.Types;

namespace Telegram.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        private readonly IUpdateService _updateService;

        public WebhookController(IUpdateService updateService)
        {
            _updateService = updateService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update update)
        {
            await _updateService.ResolveState(update);
            return Ok();
        }
    }
}
