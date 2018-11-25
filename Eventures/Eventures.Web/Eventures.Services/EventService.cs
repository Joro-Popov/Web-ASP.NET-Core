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
                    EventId = e.Id,
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

        public void Order(OrderViewModel model, string userId)
        {
            var order = new Order()
            {
                EventId = model.EventId,
                OrderedOn = DateTime.UtcNow,
                TicketsCount = model.TicketsCount,
                UserId = userId
            };

            this.Context.Orders.Add(order);
            this.Context.SaveChanges();
        }
        public IEnumerable<MyEventsViewModel> GetMyEvents(ApplicationUser user)
        {
            var events = user.Orders
                .Select(o => new MyEventsViewModel()
                {
                    Name = o.Event.Name,
                    End = o.Event.End.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture),
                    Start = o.Event.Start.ToString("dd-MMM-yy HH:mm:ss", CultureInfo.InvariantCulture),
                    Tickets = o.TicketsCount
                });

            return events;
        }
    }
}
