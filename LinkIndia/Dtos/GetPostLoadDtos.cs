using System;
namespace LinkIndia.Dtos
{
    public class GetPostLoadDtos
    {
        public int Id { get; set; }
        public string TruckCapacity { get; set; }
        public string LoadFrom { get; set; }
        public string LoadTo { get; set; }
        public string TruckType { get; set; }
        public string MaterialType { get; set; }
        public int NumberOfTrucks { get; set; }
        public float Weight { get; set; }
        public DateTime Date { get; set; }
        public string Mobile { get; set; }
    }
}
