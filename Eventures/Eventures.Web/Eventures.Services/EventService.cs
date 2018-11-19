using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Models;
using Eventures.Models.ViewModels;
using Eventures.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Eventures.Services
{
    public class EventService : IEventService
    {
        private readonly ILogger<EventService> logger;
        public EventuresDbContext Context { get; }

        public EventService(EventuresDbContext context, ILogger<EventService> logger)
        {
            this.logger = logger;
            Context = context;
        }

        public async Task<IEnumerable<EventViewModel>> GetAllEventsAsync()
        {
            var events = await this.Context.Events
                .Select(e => new EventViewModel()
                {
                    Name = e.Name,
                    Start = e.Start.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture),
                    End = e.End.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture),
                    Place = e.Place
                })
                .ToListAsync();

            return events;
        }

        public void CreateEvent(CreateViewModel model)
        {
            var newEvent = new Event()
            {
                Name = model.Name,
                TotalTickets = model.TotalTickets,
                PricePerTicket = model.PricePerTicket,
                End = model.End,
                Start = model.Start,
                Place = model.Place
            };

            this.Context.Events.Add(newEvent);
            this.Context.SaveChanges();

            this.logger.LogInformation($"Event created: {newEvent.Name}");
        }
    }
}
