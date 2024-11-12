using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrototypeWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    locationid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    State = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    Country = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__location__306F78A6B4407AEA", x => x.locationid);
                });

            migrationBuilder.CreateTable(
                name: "routes",
                columns: table => new
                {
                    Routeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Distance = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__routes__80969725C15F1B88", x => x.Routeid);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    LastName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, collation: "Latin1_General_BIN2"),
                    ContactNumber = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tmp_ms_x__CBA1B257EE93BEAA", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    warehouseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacity = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: true),
                    locationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__warehous__102BC9BFA812E5C8", x => x.warehouseid);
                    table.ForeignKey(
                        name: "FK_Warehouse_Location",
                        column: x => x.locationID,
                        principalTable: "locations",
                        principalColumn: "locationid");
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    vehicleid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    vin = table.Column<string>(type: "varchar(17)", unicode: false, maxLength: 17, nullable: false),
                    plate = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    driverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__vehicles__5BE2516AB4535C9A", x => x.vehicleid);
                    table.ForeignKey(
                        name: "FK_Vehicle_Driver",
                        column: x => x.driverID,
                        principalTable: "users",
                        principalColumn: "userid");
                });

            migrationBuilder.CreateTable(
                name: "shipments",
                columns: table => new
                {
                    Shipmentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeliveryDate = table.Column<DateOnly>(type: "date", nullable: true),
                    ShipmentType = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: false),
                    vehicleID = table.Column<int>(type: "int", nullable: false),
                    routeID = table.Column<int>(type: "int", nullable: false),
                    warehouseID = table.Column<int>(type: "int", nullable: false),
                    OriginLocationID = table.Column<int>(type: "int", nullable: false),
                    DestinationLocationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__shipment__5CAE3385E4B2725B", x => x.Shipmentid);
                    table.ForeignKey(
                        name: "FK_Shipment_DestinationLocation",
                        column: x => x.DestinationLocationID,
                        principalTable: "locations",
                        principalColumn: "locationid");
                    table.ForeignKey(
                        name: "FK_Shipment_OriginLocation",
                        column: x => x.OriginLocationID,
                        principalTable: "locations",
                        principalColumn: "locationid");
                    table.ForeignKey(
                        name: "FK_Shipment_Route",
                        column: x => x.routeID,
                        principalTable: "routes",
                        principalColumn: "Routeid");
                    table.ForeignKey(
                        name: "FK_Shipment_User",
                        column: x => x.userID,
                        principalTable: "users",
                        principalColumn: "userid");
                    table.ForeignKey(
                        name: "FK_Shipment_Vehicle",
                        column: x => x.vehicleID,
                        principalTable: "vehicles",
                        principalColumn: "vehicleid");
                    table.ForeignKey(
                        name: "FK_Shipment_Warehouse",
                        column: x => x.warehouseID,
                        principalTable: "warehouses",
                        principalColumn: "warehouseid");
                });

            migrationBuilder.CreateTable(
                name: "tracking",
                columns: table => new
                {
                    trackingid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shipmentid = table.Column<int>(type: "int", nullable: false),
                    CurrentLocation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tracking__A81A70C6529E779E", x => x.trackingid);
                    table.ForeignKey(
                        name: "FK_Tracking_Shipment",
                        column: x => x.Shipmentid,
                        principalTable: "shipments",
                        principalColumn: "Shipmentid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_shipments_DestinationLocationID",
                table: "shipments",
                column: "DestinationLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_shipments_OriginLocationID",
                table: "shipments",
                column: "OriginLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_shipments_routeID",
                table: "shipments",
                column: "routeID");

            migrationBuilder.CreateIndex(
                name: "IX_shipments_userID",
                table: "shipments",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_shipments_vehicleID",
                table: "shipments",
                column: "vehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_shipments_warehouseID",
                table: "shipments",
                column: "warehouseID");

            migrationBuilder.CreateIndex(
                name: "UQ__tracking__5CAE33840FCA4FF0",
                table: "tracking",
                column: "Shipmentid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_driverID",
                table: "vehicles",
                column: "driverID");

            migrationBuilder.CreateIndex(
                name: "IX_warehouses_locationID",
                table: "warehouses",
                column: "locationID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tracking");

            migrationBuilder.DropTable(
                name: "shipments");

            migrationBuilder.DropTable(
                name: "routes");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "warehouses");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
