//import data
using LogisticsWebAppAPI.Data;
namespace LogisticsWebAppAPI.Repositories
{
    // set up needed interface tasks, etc.
    public interface INFVehicleDriver
    {
        // add user actions 
        Task<IEnumerable<Vehicle>> VehicleGetDriver(int vehicleId);

    }
}
