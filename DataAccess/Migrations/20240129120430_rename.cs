using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlantName",
                table: "Plants",
                newName: "PowerPlantType");

            migrationBuilder.RenameColumn(
                name: "TaskDate",
                table: "Jobs",
                newName: "JobDate");

            migrationBuilder.RenameColumn(
                name: "PlantName",
                table: "Jobs",
                newName: "TestName");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfUnits",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PowerPlantId",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PowerPlantName",
                table: "Plants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PowerPlantPower",
                table: "Plants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EmplyoeeName",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmplyoeeSurName",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PowerPlantName",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "NumberOfUnits",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PowerPlantId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PowerPlantName",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "PowerPlantPower",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "EmplyoeeName",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "EmplyoeeSurName",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "PowerPlantName",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "PowerPlantType",
                table: "Plants",
                newName: "PlantName");

            migrationBuilder.RenameColumn(
                name: "TestName",
                table: "Jobs",
                newName: "PlantName");

            migrationBuilder.RenameColumn(
                name: "JobDate",
                table: "Jobs",
                newName: "TaskDate");
        }
    }
}
