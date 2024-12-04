### [Peer Review Document](https://1drv.ms/w/c/5cfc798acaccf72b/ES4ew7QUL01EomAFdy6rknAB0UelHyLcDlui1vfIHMAJVw?e=nhm3Qu)

### [Presentation Slides](https://1drv.ms/p/c/5cfc798acaccf72b/Ebarx9nYYFpOkJbF0VgrIj0Bp8EUxfokF3LMXskmMldMPA?e=TNToMZ)

# Logistics Web App Overiew


# Deployment Guide
### To begin implementation, first pull the most recent version of our SQL Database folder: 
1. Start with [DatabaseCreation.sql](https://github.com/ncf00003/LogisticsWebApplication/blob/main/SQL/DatabaseData.sql). Execute Query as is.
   <br> After, move on the entering the data in DatabaseData.sql
2. Then execute UserEncryptDatabaseUpdate.sql, Vehicles API Integration NF.sql, and the Shipments Update Assignment 4 NF.sql files
   <br> These allow the database to connect with web api's appropriately.
3. Proceed to all Stored Procedure files, marked with SPs
### Moving on to Project Data:
1. Pull the "PrototypeWebApplication" folder: This is the original Project File that we will build off of when moving to the next files. Implement this project folder in visual studio.
2. Pull and add the "LogisticsWebApp" folder to the PrototypeWebApplication project in Visual Studio.
3. Proceed to add a new project for the API pages: Project Files are stored in the "LogisticsWebAppAPI" Folder
4. Review all GitHub ReadMe files and Run the web Application.

### Error Troubleshooting:
Comments are listed throughout project files, start there for any issues. 
<p> The process of implementing the SQL Database must be done in the order listed above. If there is an error implementing the database, run code again using the "Create or Update" line in SQL to make sure you are using the most recent Database Structure in SQL. </p>
Note: if any issues arrise create a new database migration connection through the project manager window in Visual Studio.
<p> Avoid renaming any class file names or column items, unless addiing new tables this is unnessicary and will break functionality of the API's we created. 
</p> 
If loading new data to the database, use SQL's create or update command to do so. Optionally you can use CRUD web operations to update or add information in specific tables.    

# Web Application API Guide
Refer to API ReadMe for all Inputs, Outputs, and Purpose: <br>
[API ReadMe](https://github.com/ncf00003/LogisticsWebApplication/tree/main/LogisticsWebAppAPI#readme)

<p> For CRUD Operations Page Information, Refer to ReadMe file: <br>

   [CRUD Operations ReadMe](https://github.com/ncf00003/LogisticsWebApplication/blob/main/PrototypeWebApplication/ReadMeA5.md)
   
# Overview
**Project Name:** LogisticsWebApp

**Description:** The application is designed for logistics companies to manage and track shipments, vehicles, and warehouses while offering dynamic routing and shipment dashboards.

**Development Status:** In Development

## Key Functionalities:

1.	**Dynamic Shipping Routes**

- Allows logistics companies to view and manage dynamic shipping routes.

- Provides an overview of tracking information.

2.	**Real-Time Delivery Tracking**

- Users can track their shipments using a unique Shipment ID and User ID.

- Displays delivery status, current location, and expected delivery date.

3.	**Warehouse Management**

- Provides a warehouse summary for selected locations.

- Displays key information such as the number of shipments, address, city, and state for each warehouse.

4.	**Shipment Dashboard**

- Allows users to add shipments to the application.

- Summarizes all current shipments with relevant details like type, weight, and cost.

5.	**Shipment Search**

- Enables users to search shipments by type, retrieving all related shipment details.

6.	**Vehicle Management**

- Allows the addition of vehicles to the system.

- Provides information about vehicle models, capacities, and assigned drivers.

7.	**User Authentication**

- Includes secure login and profile creation functionalities.

- Verifies user credentials using email and password.

8.	**Interactive Learning Page**

- Educates users about logistics processes such as tracking, zones, and estimated delivery times.

- Aims to enhance user confidence and reduce confusion.

9.	**API-Driven Functionality**

- Integrates multiple APIs to power features like:

- Vehicle-driver associations.

- Shipment addition and updates.

- Ensures a scalable and modular approach to app functionality.

10.	**Database Integration**

- A normalized MySQL database is used to store user profiles, tracking information, shipment details, and warehouse data.

- Supports efficient queries through stored procedures for shipment tracking, vehicle information, and more.

11.	**Privacy and Security**

- Includes a detailed Privacy Policy page.

- Ensures data protection and clear communication about data usage.

12.	**Scalability and Future Enhancements**

- Modular design to enable the addition of new functionalities like:

- Real-time driver tracking.

- Advanced route optimization using historical data.

- Dynamic quoting systems for cost prediction.

## Technology Stack

- .NET
- Razor Pages
- MySQL Server


# Developer Documentation
## Architecture Summary
- The app uses a layered architecture with a .NET backend, MySQL database, and Bootstrap-styled front-end.
- Key technologies include:
- Backend: ASP.NET, EF Core
- Frontend: Bootstrap, JavaScript
- APIs: Weather API, custom shipment and vehicle APIs
- Database: MySQL (normalized to 3NF)

## Codebase Structure
- **Folder Structure:**
- Controllers/: Handles incoming HTTP requests.
- Services/: Contains business logic and API integrations.
- Models/: Defines data models and DTOs.
- Data/: Contains EF Core DbContext and database interaction logic.
- SQL/: Contains SQL scripts for database setup and stored procedures.
- wwwroot/: Static files for the front-end (CSS, JavaScript).
- **Key Components:**
- **DbContext Class (**LCDbContextClass**)**:
- Central class for database interaction.
- Maps entities to database tables.
- **Controllers**:
- LCapisController: Handles shipment and warehouse APIs.
- LukeAddVehicleController, etc.: Manage specific functionalities.
- **Stored Procedures**:
- spAddShipment, spDeliveryTracking, spNewVehicle, spVehicleDrivers, spSumShipmentsWarehouse, spShipmentType, spCreateUserProfile, spVerifyLogin: Key for database operations.

## Database
- **Database Schema:**
- Normalized MySQL database with tables for:
- Users
- Shipments
- Vehicles
- Warehouses
- Include ER diagrams if available.
- **Stored Procedures:**
- Located in SQL folder.
- Key procedures:
- **spDeliveryTracking**
- **Description:** Retrieves user delivery date and tracking information, formatted similar to an order email.
- **Parameters:**
- @userid
- @shipmentid (int)
- **spVehicleDrivers**
- **Description:** Retrieves all drivers based on a vehicle ID.
- **Parameters:**
- @vehicleid
- **spCountShipmentsWarehouse**
- **Description:** Retrieves the total number of shipments in a warehouse or incoming to a warehouse.
- **Parameters:**
- @warehouseid (int)
- **spAddShipment**
- **Description:** Adds a new shipment to the shipments table.
- **Parameters:**
- @DeliveryDate (DATE = NULL)
- @ShipmentType (NVARCHAR(50))
- @Weight (DECIMAL(18, 2))
- @Cost (DECIMAL(18, 2))
- @userID (int)
- @vehicleID (int = NULL)
- @routeID (int = NULL)
- @warehouseID (int = NULL)
- @OriginLocationID (int = NULL)
- @DestinationLocationID (int = NULL)
- **spShipmentType**
- **Description:** Finds all shipments based on shipment type.
- **Parameters:**
- @ShipmentType
- **spNewVehicle**
- **Description:** Adds a new vehicle to the database.
- **Parameters:**
- @model (string)
- @vin (string)
- @plate (string)
- @capacity (int)
- @driverID (int)
- **spCreateUserProfile**
- **Description:** Creates a user profile or returns a message if the profile already exists.
- **Parameters:**
- @Firstname
- @LastName
- @Email
- @Password
- @ContactNumber
- @Address
- **spVerifyLogin**
- **Description:** Verifies a user’s email and password for account login.
- **Parameters:**
- @Email
- @Password
- **Data Initialization:**
- Sample data scripts are included in the SQL folder.

## Front-End
- **Styling:**
- Uses the Minty Bootswatch theme for Bootstrap.
- Custom CSS classes are defined for cohesive styling.
- **Interactive Elements:**
- JavaScript is used for table toggles and dynamic features like hiding/showing elements.
- **Future Enhancements:**
- Include more visually engaging graphics and user-friendly interfaces.

## Future Enhancements
- Implement dynamic quoting and cost estimation features.
- Add real-time driver location tracking to enhance shipment monitoring.
- Develop advanced analytics dashboards for logistics performance metrics.
- Incorporate weather data for accurate delivery time estimates and dynamic pricing.

## Troubleshooting 
- **Common Issues:**
- Database connection errors: Verify appsettings.json.
- API failures: Check input validation in controllers.
- **Debugging Tips:**
- Use Visual Studio’s debugger for step-by-step execution.
- Check logs for detailed error messages.

### Resources
- Utilized ChatGPT to help format and proofread read me from previous read me(s). 
