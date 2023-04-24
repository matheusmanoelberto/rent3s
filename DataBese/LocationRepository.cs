namespace rent3s.DataBase;

using System.Data;
using rent3s.Domain.Interfaces;

public class LocationRepository : ILocationRepository
{
    private readonly IConnectionDB _connection;

    public LocationRepository(IConnectionDB connection)
    {
        _connection = connection;
        
    }
    public DataView GetLocations(int page = 0, int per_page = 10)
    {
        string sql = $"select * from locations offset {page * per_page} limit {per_page}";
        return _connection.GetDataView(sql);
    }
}