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
    public class LukeAddVehicleService : LukeAddVehicleInterface
    {
        // allows you to interact with the database
        private readonly LukeDbContextClass _dbContext;
        public LukeAddVehicleService(LukeDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddVehicle(Vehicle vehicle)
        {
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@Model", vehicle.Model));
            parameter.Add(new SqlParameter("@Vin", vehicle.Vin));
            parameter.Add(new SqlParameter("@Plate", vehicle.Plate));
            parameter.Add(new SqlParameter("@Capacity", vehicle.Capacity));
            parameter.Add(new SqlParameter("@DriverId", vehicle.DriverId));

            int result = await _dbContext.Database.ExecuteSqlRawAsync(
                "exec NewVehicle @Model, @Vin, @Plate, @Capacity, @DriverId",
                parameter.ToArray()
            );
            return result;
        }
    }
}