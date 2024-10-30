/* Add using for api info and Make sure to label all your work
   - Create Own Controller
   - Create Context Class
   - Test Work When Done
 */
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

        public async Task<int> ShipmentAdd(Shipment shipment)
        {
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

            int result= await _dbContext.Database.ExecuteSqlRawAsync(
                "exec spAddShipment @DeliveryDate, @ShipmentType, @Weight, @Cost, @userID, @vehicleID, @routeID, @warehouseID, @OriginLocationID, @DestinationLocationID",
                parameter.ToArray()
            );
            return result;
        }
        public async Task<IEnumerable<ShipmentsWarehouse>> SumShipmentsWarehouse(int warehouseid)
        {
            var param = new SqlParameter("@warehouseid", warehouseid);
            var SumShipmentsWarehouse = await Task.Run(() => _dbContext.shipmentsWarehouse
                .FromSqlRaw(@"exec spSumShipmentsWarehouse @warehouseid", param).ToListAsync());
            return SumShipmentsWarehouse;
        }

    }
}
