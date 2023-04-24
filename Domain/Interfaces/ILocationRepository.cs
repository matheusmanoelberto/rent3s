
namespace rent3s.Domain.Interfaces;
using System.Data;
public interface ILocationRepository {
    public DataView GetLocations(int page = 0, int per_page = 10);// assinatura 
}