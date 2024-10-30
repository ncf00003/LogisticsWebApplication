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
    public class LukeShipmentTypeService : LukeShipmentTypeInterface
    {
        // allows you to interact with the database
        private readonly LukeDbContextClass _dbContext;
        public LukeShipmentTypeService(LukeDbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        // Define Methods based on stored procudures -- parameters must be in specific table

        
