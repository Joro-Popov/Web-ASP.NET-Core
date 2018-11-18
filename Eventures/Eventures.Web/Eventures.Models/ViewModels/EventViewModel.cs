using System;
using System.Collections.Generic;
using System.Text;

namespace Eventures.Models.ViewModels
{
    public class EventViewModel
    {
        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Place { get; set; }
    }
}
