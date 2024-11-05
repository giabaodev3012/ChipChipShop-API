using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChipChipShop.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "77cd9abe-c41b-40f5-affa-711eedbafec4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "520b2620-3eac-4a14-9bc2-9c6bfaa82a75", "AQAAAAEAACcQAAAAEB7VKck0F+d3bEY+OadiHMdKkfnRNo2fPZ5qJuLm50FeHqySaXLhTRb1h+U1kQO2LA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 25, 15, 46, 1, 733, DateTimeKind.Local).AddTicks(8267));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6007229e-2a55-4949-9d8f-25b7cfa0bea0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e32dfe29-5830-4cd1-9ac2-11531cf7c950", "AQAAAAEAACcQAAAAEJ1OBM3vWqt4g+0FS3JbqYr0UCmpTtLcyq2H4FjXdTRUXb2MNZMPWg+SJSfJTagbkQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 10, 25, 15, 37, 19, 874, DateTimeKind.Local).AddTicks(2671));
        }
    }
}
