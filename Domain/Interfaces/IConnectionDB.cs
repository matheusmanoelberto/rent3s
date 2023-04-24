namespace rent3s.Domain.Interfaces;
using System.Data;

public interface IConnectionDB {
    public DataView GetDataView(string sql);
    
}