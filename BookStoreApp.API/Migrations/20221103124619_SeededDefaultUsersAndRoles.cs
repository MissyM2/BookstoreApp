using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price ",
                table: "Books",
                newName: "Price");

            migrationBuilder.RenameIndex(
                name: "UQ__Books__447D36EA8779CE7A",
                table: "Books",
                newName: "UQ__Books__447D36EA09FAB742");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8343074e-8623-4e1a-b0c1-84fb8678c8f3", "cf1d463b-0fc4-40c3-8e51-3845101c043d", "User", "USER" },
                    { "c7ac6cfe-1f10-4baf-b604-cde350db9554", "5e39cc03-0535-4006-ad55-8121ead88682", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30a24107-d279-4e37-96fd-01af5b38cb27", 0, "a7cf8bab-09dd-4260-b9b0-c0a0dcc27e8e", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAEAACcQAAAAELIiWQk0tyVO0kpdumzelTi1d2p7wqQiwfqgYbD03CgmLclncUIYYsSQqApD9AurNQ==", null, false, "7ed085cb-cc39-4148-9309-5916cee60ef4", false, "user@bookstore.com" },
                    { "8e448afa-f008-446e-a52f-13c449803c2e", 0, "83d94302-008a-4d2d-b530-fa6de5d0ed4a", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAEAACcQAAAAEFXkfJ1u5v/WywIyvg5JRSGSe/mnMTFikDPG6dAQxL2bYvWoJDrNoqu9iKg5p5JPLw==", null, false, "83daa7d4-372c-4bc1-9f8b-54dc6b041b61", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8343074e-8623-4e1a-b0c1-84fb8678c8f3", "30a24107-d279-4e37-96fd-01af5b38cb27" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c7ac6cfe-1f10-4baf-b604-cde350db9554", "8e448afa-f008-446e-a52f-13c449803c2e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8343074e-8623-4e1a-b0c1-84fb8678c8f3", "30a24107-d279-4e37-96fd-01af5b38cb27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c7ac6cfe-1f10-4baf-b604-cde350db9554", "8e448afa-f008-446e-a52f-13c449803c2e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8343074e-8623-4e1a-b0c1-84fb8678c8f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac6cfe-1f10-4baf-b604-cde350db9554");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30a24107-d279-4e37-96fd-01af5b38cb27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e448afa-f008-446e-a52f-13c449803c2e");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Books",
                newName: "Price ");

            migrationBuilder.RenameIndex(
                name: "UQ__Books__447D36EA09FAB742",
                table: "Books",
                newName: "UQ__Books__447D36EA8779CE7A");
        }
    }
}
