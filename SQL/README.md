# LogisticsWebApp-DataBase
### Company Statement
Now that we have a prototype web application, our Logistics firm needs to create a database. 
In doing so, we will be able to store users, tracking and route information referencable by our web app. 
<p> Additionally, having a database allows us to improve functionallity of our web application. Using back-end MySQL code helps us to improve the functionality of our front-end development. A seperate database improves security as well by not having our data easily accessible within our front-end code. </p>

### Stored Procedures and End User Actions
<strong> 1. spDeliveryTracking </strong>
<br> Description: Find User Delivery Date and Tracking Information with format similar to an order emails </br>
<p> Parameters: 
<br> • @userid 
<br> • @shipmentid int </p>

<strong> 2. spVehicleDrivers </strong>
<br> Description: Find all drivers based on a vehicle </br>
<p> Parameters: 
<br> • @vehicleid </p>

<strong> 3. spCountShipmentsWarehouse </strong>
<br> Description: Finds how many shipments are either in the warehouse or incoming to the warehouse.</br>
<p> Parameters: 
<br> • @warehouseid int </p>

<strong> 4. spAddShipment </strong>
<br> Description:  Adds a new shipment to the shipments table</br>
<p> Parameters: 
<br> • @DeliveryDate DATE = NULL,
<br> • @ShipmentType NVARCHAR(50),
<br> • @Weight DECIMAL(18, 2),
<br> • @Cost DECIMAL(18, 2),
<br> • @userID INT,
<br> • @vehicleID INT = NULL,
<br> • @routeID INT = NULL,
<br> • @warehouseID INT = NULL,
<br> • @OriginLocationID INT = NULL,
<br> • @DestinationLocationID INT = NULL </p>

<strong> 5. spShipmentType </strong>
<br> Description: Find all shipments based on shipment type </br>
<p> Parameters: 
<br> • @ShipmentType </p>

<strong> 6. spNewVehicle </strong>
<br> Description: Add a new vehicle to the database </br>
<p> Parameters: 
<br> • @model
<br> • @vin
<br> • @plate
<br> • @capacity
<br> • @driverID </p>

<strong> 7. sp(CreateUserProfile) </strong>
<br> Description: To create a profile or return a message if the profile already exists  </br>
<p> Parameters:
<br> • @(Firstname)
<br> • @(LastName)
<br> • @(Email)
<br> • @(Password)
<br> • @(ContactNumber)
<br> • @(Address) </p>

<strong> 8. sp(VerifyLogin) </strong>
<br> Description: To verify a users email and password to login to account  </br>
<p> Parameters: 
<br> • @(Email)
<br> • @(Password) </p>

# Collaborative Work
## Natalia Furmanek 
<strong>1. Create Database Tables </strong>
<br> Created tables using MySQL. <br>

<strong>2. Stored Procedures: 1 & 2 </strong>
<br>  • spDeliveryTracking </br>
 • spVehicleDrivers

<strong>3. Resources </strong>
<br> ChatGPT Used to Generate Table Ideas </br>
<p> Prompts Used: 
<br> "Ideas for logistics web app database" </br>
</p>

## Leonardo Cuellar
<strong>1. Update Database Tables </strong>
<br> Updated Table columns to add in joins in effort to normalize database. Added in data. </br>

<strong>2. Stored Procedures: 3 & 4 </strong>

<strong>3. Resources </strong>
<br> ChatGPT for Mock Data, Normalization Help, and convert attributes to parameters </br>
<p> Prompts Used: 
<br> Make these into parameters: [Procedure 4 attributes from table shipments]
<br> Can you help me normalize this database in third normal form in SQL server: [Previous code for DB creation] (Note for prompt: Database was already created but it was in 2NF, the prompt helped me normalize it and clean it as it had many "alter table", and was throwing errors).
<br> [After previous prompt] Now help me add some sample data to this database. Probably 3 rows to each table. 
</p>

## Luke Chittenden
<strong>1. Stored Procedures: 5 & 6 </strong>
<br>  • spShipmentType </br>
 • spNewVehicle

<strong>2. Resources </strong>
<br> [W3 Schools](https://www.w3schools.com/sql/default.asp) </br>
<br> ChatGPT </br>
<p> Prompts Used:
<br> "Write a return message in sql server that lets the user know that there are no values found that match the input using the @@ROWCOUNT function"</br>
</p>

## Landen Riggleman
<strong>1. Stored Procedures: 7 & 8 </strong>
<br>  • spCreateUserProfile </br>
 • spVerifyLogin </br>
<strong>2. Resources </strong>
<br> ChatGPT used to check code for errors on stored procedures  </br>
<p> Prompts Used: "Please review the follwong sql stored procedure for mistakes" </p>
