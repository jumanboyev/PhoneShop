
namespace PhoneShop.DataAccess.Utils;

public class PaginationParams
{
    public int PageNumber { get; set; }

    public int Pagesize { get; set; }

    public int SkipCount { get
        {
            return (PageNumber - 1) * Pagesize;
        }
    }
}
