
using Microsoft.AspNetCore.Http;

namespace PhoneShop.Service.Dtos.Media;

public class ImageCreateDto
{
    public IFormFile File { get; set; } = default!;

}
