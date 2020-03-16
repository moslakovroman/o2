﻿namespace model.ViewModels
{
    public class AddressViewModel : BaseModel
    {
        
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string[] HouseNumber { get; set; }
        
    }
}