using System;
using System.Collections.Generic;
using LinkIndia.Models;

namespace LinkIndia.Dtos
{
    public class GetTruckTypesDtos
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public List<TruckSubTypes> TruckSubTypes { get; set; }
    }
}
