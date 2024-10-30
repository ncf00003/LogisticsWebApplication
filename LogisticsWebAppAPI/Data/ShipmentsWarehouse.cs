using System.ComponentModel.DataAnnotations;

namespace LogisticsWebAppAPI.Data
{
    public class ShipmentsWarehouse
    {
        [Key]
        public int warehouseid { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string City { get; set; }


        public int ShipmentsNum { get; set; }




    }
}
