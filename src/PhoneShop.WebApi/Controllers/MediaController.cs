using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneShop.Service.Dtos.Media;

namespace PhoneShop.WebApi.Controllers
{
    [Route("api/media")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        [HttpPost("Image")]

        public async Task<string> CreateImageAsync([FromForm] ImageCreateDto imageDto)
        {
            return "";
        }

        [HttpPost("Avatar")]

        public async Task<string> CreateAvatarAsync([FromForm] AvatarCreateDto avatarDto)
        {
            return "";
        }
    }
}
