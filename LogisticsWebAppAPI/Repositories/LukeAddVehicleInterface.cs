using LogisticsWebAppAPI.Data;

namespace LogisticsWebAppAPI.Repositories
{
    public interface LukeAddVehicleInterface
    {
        Task<int> AddVehicle(Vehicle vehicle);
    }
}