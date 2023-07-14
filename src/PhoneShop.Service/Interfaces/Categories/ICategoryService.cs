
using PhoneShop.Service.Dtos.Categories;

namespace PhoneShop.Service.Interfaces.Categories;

public interface ICategoryService
{
    public Task<bool> CreateAsync(CategoryCreateDto dto);

    public Task<bool> DeleteAsync(int id);
}
