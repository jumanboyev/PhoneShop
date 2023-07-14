
using Npgsql;

namespace PhoneShop.DataAccess.Repasitories;

public class BaseRepository
{
    protected readonly NpgsqlConnection _connection;

    public BaseRepository()
    {
        Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        this._connection = new NpgsqlConnection("Host=localhost;Port=5432;Database=phone-shop-db;User Id=postgres;Password=nt20030726");
    }
}
