using System;
namespace LinkIndia.Dtos
{
    public class AddTransporterDtos
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string TransportName { get; set; }
        public string BusinessAddressProof { get; set; } = null;
        public string Add_Line1 { get; set; }
        public string Add_Line2 { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string AddressProof { get; set; } = null;
        public string Selfie { get; set; } = null;
        public string Pancard { get; set; } = null;
    }
}
