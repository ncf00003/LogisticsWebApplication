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

**Description:** This webapp will aim to help the user keep track of shipments for a logistics company as well as provide accurate timing and dynamic quotes using normal and climate data in locations and stations in the route. 

**Development Status:** In Development

**Key Functionalities:**
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

**Technology Stack**

- .NET
- Razor Pages
- MySQL Server


# Developer Documentation



