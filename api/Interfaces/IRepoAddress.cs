using System.Collections.Generic;
using api.Interfaces.Repositories.Base;
using model.db;
using model.ViewModels;

namespace api.Interfaces
{
    public interface IRepoAddress : IBaseRepository<Address>
    {
        List<Address> GetAddressViewModel();
        Address DbAddress(Address model);
        List<Address> GetEmptyHousesList(int limit);
        void SaveAll(List<Address> items);
        void SaveStreets(List<AllDbInfoViewModel> items);

    }
}