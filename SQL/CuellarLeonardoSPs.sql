use LogisticsWebData
GO

-- Find number of shipments in x warehouse
create or alter proc spCountShipmentsWarehouse
@warehouseid int 
AS
BEGIN
	SELECT w.warehouseid, l.[Address], l.[State], l.City, count(s.Shipmentid) AS 'Number of Shipments'
	FROM warehouses AS w
	INNER JOIN locations as l
	ON l.locationid = w.warehouseid
	INNER JOIN shipments AS s 
	ON w.warehouseid=s.warehouseID
	GROUP BY w.warehouseid,  l.[State], l.City, l.[Address]
	HAVING w.warehouseid=@warehouseid
END
GO

/* Test spSumShipmentsWarehouse
exec spSumShipmentsWarehouse 3
GO
*/

-- Add a shipment
create or alter proc spAddShipment -- Used GPT to convert to parameters
	@DeliveryDate DATE = NULL,
    @ShipmentType NVARCHAR(50),
    @Weight DECIMAL(18, 2),
    @Cost DECIMAL(18, 2),
    @userID INT,
    @vehicleID INT = NULL,
    @routeID INT = NULL,
    @warehouseID INT = NULL,
    @OriginLocationID INT = NULL,
    @DestinationLocationID INT = NULL
AS
BEGIN
	INSERT INTO [dbo].[shipments]
           ([DeliveryDate]
           ,[ShipmentType]
           ,[Weight]
           ,[Cost]
           ,[userID]
           ,[vehicleID]
           ,[routeID]
           ,[warehouseID]
           ,[OriginLocationID]
           ,[DestinationLocationID])
     VALUES
           (@DeliveryDate,
			@ShipmentType,
			@Weight,
			@Cost,
			@userID,
			@vehicleID,
			@routeID,
			@warehouseID,
			@OriginLocationID,
			@DestinationLocationID)
END
GO

/* Test adding a shipment
exec spAddShipment '2024-10-15', Electronics, 900.33, 500, 1, 3, 2, 3, 1, 1
GO
*/