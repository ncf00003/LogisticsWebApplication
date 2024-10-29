using System.ComponentModel.DataAnnotations.Schema;

namespace LogisticsWebAppAPI.Data
{
    public class DeliveryShipment
    {
        /*s.[Shipmentid]
      ,s.[DeliveryDate]
      ,s.[ShipmentType]
      ,s.[Weight]
      ,s.[Cost]
      ,s.[userID]
      ,T.CurrentLocation
	  ,T.LastUpdated
	  ,T.OrderDate
         */
        public int ShipmentId { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string? ShipmentType { get; set; }

        public decimal Weight { get; set; }

        public decimal Cost { get; set; }

        public int UserId { get; set; }

        // Add in return results and alter stored procedure
        public string CurrentLocation { get; set; } = null!;

        public DateTime LastUpdated { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
