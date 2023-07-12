
namespace PhoneShop.Domain.Exseptions.Categories;

public class CategoryNotFoundExseptions:NotFoundExseption
{
    public CategoryNotFoundExseptions()
    {
        this.TittleMessage="Category not found";
    }
}
