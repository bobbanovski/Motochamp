using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Motochamp.Migrations
{
    public partial class seedBikeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Bikes (Brand) VALUES ('Bike1')");
            migrationBuilder.Sql("INSERT INTO Bikes (Brand) VALUES ('Bike2')");
            migrationBuilder.Sql("INSERT INTO Bikes (Brand) VALUES ('Bike3')");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike1-ModelA', (SELECT ID FROM Bikes WHERE Brand = 'Bike1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike1-ModelB', (SELECT ID FROM Bikes WHERE Brand = 'Bike1'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike1-ModelC', (SELECT ID FROM Bikes WHERE Brand = 'Bike1'))");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike2-ModelA', (SELECT ID FROM Bikes WHERE Brand = 'Bike2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike2-ModelB', (SELECT ID FROM Bikes WHERE Brand = 'Bike2'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike2-ModelC', (SELECT ID FROM Bikes WHERE Brand = 'Bike2'))");
            
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike3-ModelA', (SELECT ID FROM Bikes WHERE Brand = 'Bike3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike3-ModelB', (SELECT ID FROM Bikes WHERE Brand = 'Bike3'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, BikeID) VALUES ('Bike3-ModelC', (SELECT ID FROM Bikes WHERE Brand = 'Bike3'))");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Bikes");
        }
    }
}
