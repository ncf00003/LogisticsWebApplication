### [Peer Review Document](https://1drv.ms/w/c/5cfc798acaccf72b/ES4ew7QUL01EomAFdy6rknAB0UelHyLcDlui1vfIHMAJVw?e=nhm3Qu)

### [Presentation Slides](https://1drv.ms/p/c/5cfc798acaccf72b/Ebarx9nYYFpOkJbF0VgrIj0Bp8EUxfokF3LMXskmMldMPA?e=TNToMZ)

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
   

# Developer Documentation



# Logistics Web App Overiew
