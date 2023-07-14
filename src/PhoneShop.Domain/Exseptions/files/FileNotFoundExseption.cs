
namespace PhoneShop.Domain.Exseptions.files;

public class FileNotFoundExseption:NotFoundExseption
{
    public FileNotFoundExseption()
    {
        this.TittleMessage="Filed not Found";   
    }
}
