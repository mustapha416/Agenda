using System;
using System.Collections.Generic;

namespace agenda.Models
{
    public partial class Broker
    {
        public int IdBroker { get; set; }
        public string Lastname { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public virtual Appointment Appointment { get; set; } = null!;
    }
}
