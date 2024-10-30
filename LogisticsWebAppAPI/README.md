# LogisticsWebAppAPIs (Assignment 4)
## Overview of Pages
Continuing with our Prototype Logistics Web app, we will be introducing more functional pages for users by integrating API's.
<br> An overview of our 8 Planned pages is listed below:
### User Action Pages
1. The welcome pages
2. Learn page
3. Overview of shipping routes
4. 

### Dynamic Pages
<strong> 1. Weather Forcast Page </strong>
[Weather API](https://www.weather.gov/documentation/services-web-api)
<br> Can be used to suggest delays to user orders or possible issues in transit for drivers. </br>

<strong> 2. Delivery Tracking </strong>
<br> Users can enter their unique shipment and user ids to gain information about their shipment status and delivery. <p>

<strong> 3. </strong>
<br> <p>

<strong> 4. </strong>
<br> </br>

# Collaborative Work
## Natalia Furmanek 
<strong> 1. Project Work</strong>
<br> Created API folder and moved SQL code from Assignment 2 into Repository under 'SQL' Folder.
</br> Connected .json files to SQL Database, both API and Application. 
<br> Worked through Scaffolding and reverse engineering of database with Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer </br>
<p> Modified SQL Stored Procedures to include all table called information for API functionality. Updates are found in 'SQL' repository folder, with update listed in new file names. </p>

<strong> 2. NFDeliveryTrackingService API</strong>
<br> Purpose: Users can enter their user and shipment info to <em> get </em> shipment information and basic information about their order
</br>Inputs: @UserID and @ShipmentID
<br> Outputs: ShipmentId, DeliveryDate, ShipmentType, weight, cost, UserId, currentLocation, lastUpdated, and orderDate
<p> 
<strong> 3. NFVehicleDriverService </strong>
<br> Purpose: <em> Get </em> Vehicle Information based on Id, allows user to see how many drivers are associated with a truck
</br> Inputs: @VehicleId
<br> Outputs: VehicleId, Model, VIN, plate, capacity, driverID, driver, shipments
</p> 
<strong> 4. Resources </strong> 

[Medium CRUD Operations Article](https://medium.com/@jaydeepvpatil225/crud-operation-using-entity-framework-core-and-stored-procedure-in-net-core-6-web-api-65faf6f019f0)
<br> Used as a reference for specific operations alongside class code.


## Leonardo Cuellar
## Leonardo Cuellar

**1. Project Work**

In the backend, I made several additions: I added my DbContext class (LCDbContextClass), my controller (LCapisController), my service (LCService), my interface (ILCApisInterface), and a class to match the stored procedure's output (ShipmentsWarehouse). I also adjusted the database by changing the name of my stored procedure's output column “Number of Shipments” to “ShipmentsNum” to align with the backend. You can find the updated SQL procedures in the [LogisticsAppDatabase](https://github.com/ncf00003/LogisticsWebApp-Database/blob/main/CuellarLeonardoSPs.sql) repository.

**2.  ShipmentAdd API**

**Purpose:** Post HTTP API to add a new shipment to the shipments table. 
**Inputs:** 

•	@UserID (int): The ID of the user creating the shipment.
•	@ShipmentID (int, optional): Auto-generated or provided by the caller (in case of updates).

•	DeliveryDate (datetime): The expected delivery date of the shipment.
•	ShipmentType (string): The type/category of the shipment.
•	Weight (decimal): The weight of the shipment.
•	Cost (decimal): The cost associated with the shipment.
•	VehicleID (int): The ID of the vehicle used for transportation.
•	RouteID (int): The ID of the route taken for delivery.
•	WarehouseID (int): The ID of the warehouse associated with the shipment.
•	OriginLocationID (int): The ID of the origin location for the shipment.
•	DestinationLocationID (int): The ID of the destination location for the shipment.

JSON input used for testing:

```json
{
  "DeliveryDate": "2024-10-29T19:30:51.421Z",
  "ShipmentType": "Cargo",
  "Weight": 900.0,
  "Cost": 1300.0,
  "UserId": 1,
  "VehicleId": 2,
  "RouteId": 3,
  "WarehouseId": 4,
  "OriginLocationId": 5,
  "DestinationLocationId": 6
}
```

**Outputs:** 

•	ShipmentId (int): The unique ID of the newly added shipment.
•	DeliveryDate (datetime): The expected delivery date.
•	ShipmentType (string): The type of the shipment.
•	Weight (decimal): The weight of the shipment.
•	Cost (decimal): The total cost of the shipment.
•	UserId (int): The ID of the user who created the shipment.
•	CurrentLocation (string): The current location of the shipment (if available).
•	LastUpdated (datetime): The last updated timestamp for the shipment record.
•	OrderDate (datetime): The order creation date.

**3.  SumShipmentsWarehouse API**

**Purpose:** GET HTTP API to retrieve the count of shipments (which I amusingly called "sum") for a specified warehouse (input parameter).

**Inputs:** 

•	@WarehouseID (int): The ID of the warehouse for which the shipment summary is being retrieved.
**Outputs:**

•	WarehouseID (int): The ID of the warehouse.
•	Address (string): The address of the warehouse.
•	State (string): The state where the warehouse is located.
•	City (string): The city where the warehouse is located.
•	ShipmentsNum (int): The total number of shipments at the specified warehouse.

**Resources:**

Used ChatGPT to convert SQL to C# parameters:
Prompt:

This is a add using the spAddShipment procedure with the following parameters:

[SQLParameters]

Change it to the following format for my .net app to execute the procedure:

[Example of Code to convert]

Used ChatGPT to help write read me:
Prompt:

I am adding a read me for the following API I need the following:
Inputs: @UserID and @ShipmentID
Outputs: ShipmentId, DeliveryDate, ShipmentType, weight, cost, UserId, currentLocation, lastUpdated, and orderDate
Here is my code:
[C# Code]

Used ChatGPT for sample body to test my GET API Call:

Give me the sample json to test my api:
These are the parameters:
[C# Code]

Used NotionAI improve writing feature to proofread readme.

## Luke Chittenden
<strong> 1. Project Work</strong>

<strong> 2.  API</strong>

<strong> 3.  API</strong>

## Landen Riggleman
<strong> 1. Project Work</strong>

<strong> 2.  API</strong>

<strong> 3.  API</strong>
