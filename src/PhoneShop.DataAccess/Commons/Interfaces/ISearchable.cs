
using PhoneShop.DataAccess.Utils;

namespace PhoneShop.DataAccess.Commons.Interfaces;

public interface ISearchable<TModel>
{
    public Task<(int ItemCount, IList<TModel>)> SearchAsync(string search, PaginationParams @params);
}
