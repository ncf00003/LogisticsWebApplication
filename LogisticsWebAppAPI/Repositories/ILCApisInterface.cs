using LogisticsWebAppAPI.Data;

namespace LogisticsWebAppAPI.Repositories
{
    public interface ILCApisInterface
    {
        // Added service reference for Shipment class
        Task<int> ShipmentAdd(Shipment shipment);
        // Added service reference for ShipmentsWarehouse class
        Task<IEnumerable<ShipmentsWarehouse>> SumShipmentsWarehouse(int warehouseid);

    }
}
