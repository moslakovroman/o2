using System.Collections.Generic;
using model.db;
using model.Filters;
using model.ViewModels;

namespace api.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T> where T : class
    {
        T Save(T item);
        T Get(long id);
        void Delete(T item);
        List<Address> GetByFilter(BaseFilter filterObject);
        List<AllDbInfoViewModel> DbFilter(BaseFilter filterObject);
    }
}