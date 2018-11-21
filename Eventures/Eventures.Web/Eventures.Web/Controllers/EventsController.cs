using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models.ViewModels;
using Eventures.Services.Interfaces;
using Eventures.Web.Filters;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public async Task<IActionResult> All()
        {
            var allEvents = await this.EventService.GetAllEventsAsync();

            return this.View(allEvents.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [TypeFilter(typeof(LogEventFilter))]
        [TypeFilter(typeof(InvalidModelStateFilter))]
        [Authorize(Roles = "Admin")]
        public IActionResult Create(CreateViewModel model)
        {
            if(!ModelState.IsValid) throw new InvalidOperationException();

            this.EventService.CreateEvent(model);

            return this.RedirectToAction("All");
        }
    }
}
