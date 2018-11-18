using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Models;
using Eventures.Models.ViewModels;
using Eventures.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eventures.Services
{
    public class EventService : IEventService
    {
        public EventuresDbContext Context { get; }

        public EventService(EventuresDbContext context)
        {
            Context = context;
        }

        public async Task<IEnumerable<EventViewModel>> GetAllEventsAsync()
        {
            var events = await this.Context.Events
                .Select(e => new EventViewModel()
                {
                    Name = e.Name,
                    Start = e.Start,
                    End = e.End,
                    Place = e.Place
                })
                .ToListAsync();

            return events;
        }
    }
}
