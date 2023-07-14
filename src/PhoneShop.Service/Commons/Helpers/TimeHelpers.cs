
using PhoneShop.Domain.Constans;

namespace PhoneShop.Service.Commons.Helpers;

public class TimeHelpers
{
    public static DateTime GetDateTime()
    {
        var dbTime = DateTime.UtcNow;
        dbTime.AddHours(TimeConstants.UTC);
        return dbTime;
    }
}
