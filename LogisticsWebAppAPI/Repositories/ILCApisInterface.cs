using LogisticsWebAppAPI.Data;

namespace LogisticsWebAppAPI.Repositories
{
    public interface ILCApisInterface
    {
        Task<int> ShipmentAdd(Shipment shipment);
    }
}
