﻿// import data folder
using LogisticsWebAppAPI.Data;
namespace LogisticsWebAppAPI.Repositories
{
    public interface INFDeliveryTracking
    {

        // Read Service Tracking Information by Ship ID (read CRUD)
        public Task<IEnumerable<DeliveryShipment>> GetShipmentIdAsync(int ShipmentId, int userId);
       

    }
}
