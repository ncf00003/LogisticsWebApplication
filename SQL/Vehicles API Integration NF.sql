USE [LogisticsWebData]
GO

/****** Object:  StoredProcedure [dbo].[spVehicleDrivers]    Script Date: 10/29/2024 3:02:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

--spVehicleDrivers 2: Find all drivers based on a vehicle
ALTER   proc [dbo].[spVehicleDrivers]
@vehicleid int
AS
BEGIN
	SELECT
	V.[vehicleid]
      ,V.[model]
      ,V.[vin]
      ,V.[plate]
      ,V.[capacity]
      ,V.[driverID]
	/* V.vehicleid,
	V.model,
	V.vin,
	V.plate
	--CONCAT for display purposes
	--CONCAT (U.FirstName, ' ', U.LastName) as [Driver] */
	FROM 
	dbo.vehicles V
	-- JOIN to users on driverid as FK link - INNER Since id must match with a 'driver'
	INNER JOIN dbo.users U on V.driverID = U.userid
	WHERE V.vehicleid = @vehicleid
END
GO


