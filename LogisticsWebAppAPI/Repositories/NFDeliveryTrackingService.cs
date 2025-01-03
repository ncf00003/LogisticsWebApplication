﻿/* Add using for api info and Make sure to label all your work
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
        // Define Methods based on stored procudures -- parameters must be in specific table
   
        // Search Shipment status by Shipment ID = read details from stored proc based on ShipID
        public async Task<IEnumerable<DeliveryShipment>> GetShipmentIdAsync(int ShipmentId, int userId) // was shipment -- new modify
        {
            //define the needed parameters
            var param1 = new SqlParameter("@ShipmentId", ShipmentId);
            var param2 = new SqlParameter("@Userid", userId);

            var shipmentDetails = await Task.Run(() => _dbContext.deliveryshipment
                .FromSqlRaw("exec spDeliveryTracking @userid, @shipmentid", param1, param2).ToListAsync());
            return shipmentDetails;
            
            //stored proc is based on info that is considered read only to users, this is like searching on an order based on 
            //the given shipment id and your email (functioning as userid). 
        
        }


    }
}
