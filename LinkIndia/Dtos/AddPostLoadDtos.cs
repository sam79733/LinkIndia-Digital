using System;
namespace LinkIndia.Dtos
{
    public class AddPostLoadDtos
    {
        public string TruckCapacity { get; set; }
        public string LoadFrom { get; set; }
        public string LoadTo { get; set; }
        public int TruckType { get; set; }
        public string MaterialType { get; set; }
        public int NumberOfTrucks { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
        public string Mobile { get; set; }
        public int TruckSubType { get; set; }
    }
}
