using System;
using LinkIndia.Models;
namespace LinkIndia.Dtos
{
    public class AddPostTruckDtos
    {
        
        public string OwnerName { get; set; }
        public string Mobile { get; set; }
        public int TruckTypeId { get; set; }
        public int TruckSubTypeId { get; set; }
        public string State { get; set; }
        public string VehicleNumber { get; set; }
        public string RouteFrom { get; set; }
        public string RouteTo { get; set; }
        public string AddharNumber { get; set; }
        public string RCFront { get; set; }
        public string RCBack { get; set; }
    }
}
