
using PhoneShop.DataAccess.Utils;

namespace PhoneShop.DataAccess.Commons.Interfaces;

public interface IGetAll<TModel>
{
    public Task<IList<TModel>> GetAllAsync(PaginationParams @params);
}
