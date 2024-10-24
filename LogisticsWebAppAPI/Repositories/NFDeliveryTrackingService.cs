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
    public class NFDeliveryTrackingService : INFDeliveryTracking
    {
        // allows you to interact with the database
        private readonly NFDbContextClass _dbContext;
        public NFDeliveryTrackingService(NFDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        // Define Methods based on stored procudures
        public async Task<int> DeliveryTrackingRead(User user, Shipment shipment)
        {
            // parameters must be in specific table
            var parameter = new List<SqlParameter>();
            parameter.Add(new SqlParameter("@userid", user.Userid));

            parameter.Add(new SqlParameter("@shipmentid", shipment.Shipmentid));

            return await _dbContext.Database.ExecuteSqlRawAsync("exec spDeliveryTracking @userid, @shipmentid", parameter.ToArray());
        }


    }
}
