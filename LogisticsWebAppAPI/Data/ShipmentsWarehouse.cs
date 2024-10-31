using System.ComponentModel.DataAnnotations;

namespace LogisticsWebAppAPI.Data
{
    // Added custom class to return the sum of shipments in the warehouse
    public class ShipmentsWarehouse
    {
        // Primary key
        [Key] 
        // Added properties to return the sum of shipments in the warehouse
        public int warehouseid { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string City { get; set; }


        public int ShipmentsNum { get; set; }




    }
}
