﻿using System;
namespace LinkIndia.Models
{
    public class Client_LoadReg
    {
        public Client_LoadReg()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string TransportName { get; set; }
        public string BusinessAddressProof { get; set; }
        public string Add_Line1 { get; set; }
        public string Add_Line2 { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string AddressProof { get; set; }
        public string Selfie { get; set; }
        public string Pancard { get; set; }
    }
}
