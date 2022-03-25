using System;
using System.Collections.Generic;

namespace LinkIndia.Models
{
    public class TruckType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public List<TruckSubTypes> TruckSubTypes { get; set; }
    }
}
