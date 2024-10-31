using LogisticsWebAppAPI.Data;

namespace LogisticsWebAppAPI.Repositories
{
    public interface LukeShipmentTypeInterface
    {
        Task<IEnumerable<Shipment>> ShipmentType(int shipmentid);
    }
}