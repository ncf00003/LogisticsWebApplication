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
    public class LukeShipmentTypeService : LukeShipmentTypeInterface
    {
        // allows you to interact with the database
        private readonly LukeDbContextClass _dbContext;
        public LukeShipmentTypeService(LukeDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Shipment>> ShipmentType(int shipmentid)
        {
            var param = new SqlParameter("@shipmentid", shipmentid);
            var ShipmentType = await Task.Run(() => _dbContext.shipment
                .FromSqlRaw(@"exec ShipmentType @shipmentid", param).ToListAsync());
            return ShipmentType;
        }
    }
}