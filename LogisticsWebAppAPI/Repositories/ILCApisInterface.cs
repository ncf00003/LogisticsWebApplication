using LogisticsWebAppAPI.Data;

namespace LogisticsWebAppAPI.Repositories
{
    public interface ILCApisInterface
    {
        Task<int> ShipmentAdd(Shipment shipment);
        Task<IEnumerable<ShipmentsWarehouse>> SumShipmentsWarehouse(int warehouseid);

    }
}
