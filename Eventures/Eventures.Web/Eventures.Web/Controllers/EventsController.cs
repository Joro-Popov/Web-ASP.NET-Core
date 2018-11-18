using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class EventsController : BaseController
    {
        public IEventService EventService { get; }

        public EventsController(IEventService eventService)
        {
            EventService = eventService;
        }
        public async Task<IActionResult> All()
        {
            var allEvents = await this.EventService.GetAllEventsAsync();

            return this.View(allEvents);
        }
    }
}
