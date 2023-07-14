using PhoneShop.DataAccess.Commons.Interfaces;
using PhoneShop.Domain.Entities.Category;

namespace PhoneShop.DataAccess.Interfaces.Categories;

public interface ICategoryRepository:IRepository<Category,Category>,IGetAll<Category>
{

}
