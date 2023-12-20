using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addedDetailSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 19, 5, 23, 344, DateTimeKind.Utc).AddTicks(3699), "Clothing & Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 19, 5, 23, 344, DateTimeKind.Utc).AddTicks(3719), "Garden, Garden & Beauty" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 19, 5, 23, 344, DateTimeKind.Utc).AddTicks(3734), "Books, Garden & Automotive" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 22, 5, 23, 344, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 22, 5, 23, 344, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 22, 5, 23, 344, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 22, 5, 23, 344, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 22, 5, 23, 346, DateTimeKind.Local).AddTicks(4689), "Aliquid delectus dolorem et eius.", "Est.", false },
                    { 2, 2, new DateTime(2023, 12, 20, 22, 5, 23, 346, DateTimeKind.Local).AddTicks(4754), "Animi quo aut nulla cum.", "Distinctio.", true },
                    { 3, 3, new DateTime(2023, 12, 20, 22, 5, 23, 346, DateTimeKind.Local).AddTicks(4784), "Adipisci voluptate dolorem sed tempore.", "Quod.", false }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 12, 20, 22, 5, 23, 348, DateTimeKind.Local).AddTicks(1415), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2.735319294617680m, 520.68m, "Small Wooden Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 12, 20, 22, 5, 23, 348, DateTimeKind.Local).AddTicks(1442), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7.217877086743430m, 143.08m, "Generic Rubber Bike" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 18, 56, 38, 613, DateTimeKind.Utc).AddTicks(3693), "Tools, Garden & Music" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 18, 56, 38, 613, DateTimeKind.Utc).AddTicks(3725), "Garden, Computers & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 12, 20, 18, 56, 38, 613, DateTimeKind.Utc).AddTicks(3744), "Tools, Outdoors & Beauty" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 21, 56, 38, 613, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 21, 56, 38, 613, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 21, 56, 38, 613, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 21, 56, 38, 613, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 12, 20, 21, 56, 38, 617, DateTimeKind.Local).AddTicks(9469), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4.799913557854350m, 266.11m, "Handcrafted Plastic Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2023, 12, 20, 21, 56, 38, 617, DateTimeKind.Local).AddTicks(9501), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6.965183812066460m, 404.23m, "Sleek Plastic Table" });
        }
    }
}
