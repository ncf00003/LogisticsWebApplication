using LogisticsWebAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWebAppAPI.Repositories
{
    public class LCService : ILCApisInterface
    {
        // allows you to interact with the database
        private readonly LCDbContextClass _dbContext;
        public LCService(LCDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        // ShipmentAdd method to add a new shipment
        public async Task<int> ShipmentAdd(Shipment shipment)
        {
            // SqlParameter is used to pass parameters to the stored procedure
            // Added parameters to pass to create a new shipment procedure
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@DeliveryDate", shipment.DeliveryDate));
            parameter.Add(new SqlParameter("@ShipmentType", shipment.ShipmentType));
            parameter.Add(new SqlParameter("@Weight", shipment.Weight));
            parameter.Add(new SqlParameter("@Cost", shipment.Cost));
            parameter.Add(new SqlParameter("@userID", shipment.UserId));
            parameter.Add(new SqlParameter("@vehicleID", shipment.VehicleId));
            parameter.Add(new SqlParameter("@routeID", shipment.RouteId));
            parameter.Add(new SqlParameter("@warehouseID", shipment.WarehouseId));
            parameter.Add(new SqlParameter("@OriginLocationID", shipment.OriginLocationId));
            parameter.Add(new SqlParameter("@DestinationLocationID", shipment.DestinationLocationId));
            
            // Execute the stored procedure
            int result = await _dbContext.Database.ExecuteSqlRawAsync(
                "exec spAddShipment @DeliveryDate, @ShipmentType, @Weight, @Cost, @userID, @vehicleID, @routeID, @warehouseID, @OriginLocationID, @DestinationLocationID",
                parameter.ToArray()
            );
            // Return the result
            return result;
        }
        // SumShipmentsWarehouse method to sum the shipments in the warehouse
        public async Task<IEnumerable<ShipmentsWarehouse>> SumShipmentsWarehouse(int warehouseid)
        {
            // SqlParameter is used to pass parameters to the stored procedure, only one paramater to use procedure
            var param = new SqlParameter("@warehouseid", warehouseid);
            // Execute the stored procedure
            var SumShipmentsWarehouse = await Task.Run(() => _dbContext.shipmentsWarehouse
                .FromSqlRaw(@"exec spSumShipmentsWarehouse @warehouseid", param).ToListAsync());
            // Return the result
            return SumShipmentsWarehouse;
        }

    }
}
