USE [LogisticsWebData]
GO
/****** Object:  StoredProcedure [dbo].[spDeliveryTracking]    Script Date: 10/29/2024 2:56:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--spUserDeliveryStatus 1: Find User Delivery Date and Tracking Information 
ALTER   proc [dbo].[spDeliveryTracking]
@userid int,
@shipmentid int
AS 
BEGIN	
	SELECT 
	s.[Shipmentid]
      ,s.[DeliveryDate]
      ,s.[ShipmentType]
      ,s.[Weight]
      ,s.[Cost]
      ,s.[userID]
      ,T.CurrentLocation
	  ,T.LastUpdated
	  ,T.OrderDate
	/*
	-- concat and additional columns to look like an email response
	CONCAT (U.FirstName, ' ', U.LastName) as [User],
	T.OrderDate, 
	T.CurrentLocation,
	S.DeliveryDate,
	-- Something Fancy to determine delivered or in-route
	CASE WHEN T.CurrentLocation = R.Destination
	THEN 'Delivered'
	WHEN T.CurrentLocation != R.Destination
	THEN 'In-Route'
	END AS [Status],
	T.LastUpdated
	*/
	FROM dbo.users U
	-- Inner join since there is no status without a shipment, proc is meant to be specific to a certain Delivery
	INNER JOIN dbo.shipments S on U.userid = S.userID 
	LEFT JOIN dbo.[tracking] T on S.Shipmentid = T.Shipmentid
	LEFT JOIN dbo.[routes] R on S.routeID = R.Routeid 
	WHERE U.Userid = @userid and S.Shipmentid = @shipmentid
END
