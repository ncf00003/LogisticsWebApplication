using LogisticsWebAppAPI.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LogisticsWebAppAPI.Repositories
{   // Add in the Interface reference
    public class NFVehicleDriverService : INFVehicleDriver
    {
        // needed steps private public stuff
        private readonly NFDbContextClass _dbContext;
        public NFVehicleDriverService(NFDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        /* Description: Find all drivers based on a vehicle
           Parameters: @vehicleid
           Use the table name then the value to search on 
        */
        public async Task<IEnumerable<Vehicle>> VehicleGetDriver(int vehicleId)
        {
            var param = new SqlParameter("@Vehicleid", vehicleId);
            var vehicleDetails = await Task.Run(() => _dbContext.vehicle // has to be lowercase for context class
                .FromSqlRaw(@"exec spVehicleDrivers @Vehicleid", param).ToListAsync());
            return vehicleDetails;
        }


    }
}
