using System.Collections.Generic;
using api.Interfaces;
using api.Repositories.ORMLite;
using model.db;
using model.Filters;
using model.ViewModels;
using ServiceStack.OrmLite;


namespace api.Repositories
{
    public class AddressRepository : BaseRepository<Address>, IRepoAddress
    {
        private IRepoAddress _repoAddress;


        public AddressRepository(IUnitOfWorkProvider provider) : base(provider)
        {
            
        }

        

        public List<Address> GetAddressViewModel()
        {
            return new List<Address>();
        }

        public Address DbAddress(Address address)
        {
            return _repoAddress.Save(address);
        }

        public List<Address> GetEmptyHousesList(int limit)
        {

            using (var unitOfWork = UnitOfWorkProvider.GetUnitOfWork())
            {
                var sql = $"select * from tbltestaddress where hn is null limit {limit}";
                return unitOfWork.DB.Select<Address>(sql);
                
            }


        }

        public void SaveAll(List<Address> items)
        {
            using (var unitOfWork = UnitOfWorkProvider.GetUnitOfWork())
            {
                unitOfWork.DB.InsertAll(items);
                unitOfWork.Save();
            }
        }

        public void SaveStreets(List<AllDbInfoViewModel> items)
        {
            using (var unitOfWork = UnitOfWorkProvider.GetUnitOfWork())
            {
                unitOfWork.DB.InsertAll(items);
                unitOfWork.Save();
            }
        }


        public List<AllDbInfoViewModel> DbFilter(BaseFilter filterObject)
        {
            throw new System.NotImplementedException();
        }
    }
}
