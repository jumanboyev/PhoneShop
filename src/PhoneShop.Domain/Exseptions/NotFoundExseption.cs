using System.Net;

namespace PhoneShop.Domain.Exseptions;

public class NotFoundExseption
{
    public HttpStatusCode StatusCode { get; } = HttpStatusCode.NotFound;
    
    public string TittleMessage { get; set; }=string.Empty;
}
