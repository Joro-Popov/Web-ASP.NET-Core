using System;
using System.Collections.Generic;
using System.Text;

namespace PANDA.Models.ViewModels
{
    public class ReceiptsViewModel
    {
        public int Id { get; set; }

        public decimal Fee { get; set; }

        public string IssuedOn { get; set; }

        public string Recipient { get; set; }
    }
}
