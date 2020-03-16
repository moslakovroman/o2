using System.Collections.Generic;
using model.db;
using model.ViewModels;

namespace api.Interfaces
{
    public interface IAddressService
    {
        List<Address> GetAddressInfo();
        Address DbAddress(Address model);
        Address AddHouse(Address house);
        void SaveAll(List<Address> items);
        void SaveStreets(List<AllDbInfoViewModel> items);
        
    }
}