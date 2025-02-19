using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogFullStack.Server.Migrations
{
    /// <inheritdoc />
    public partial class StaticContentAuthor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "StaticContent",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "BusinessContactDetails",
                columns: new[] { "BusinessContactID", "BusinessAddress", "BusinessContactEmail", "BusinessContactPhoneNumber", "BusinessName" },
                values: new object[,]
                {
                    { 1, "308 Negra Arroyo Lane, Albuquerque, New Mexico", "VeryRealCo@RealMail.io", "(360) 123-4567", "ToastCo" },
                    { 2, "600 Centralia College Blvd, Centralia, WA 98531", "Wingdings@Wingmail.io", "(360) 123-4567", "Wingdings inc" }
                });

            migrationBuilder.InsertData(
                table: "DynamicContent",
                columns: new[] { "DynamicContentID", "Author", "Body", "Content", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Arial Hughman", "This is a post", "Really cool stuff", new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test" },
                    { 2, "SHODAN", "Do not dawdle. I lust for my revenge.", "Really neat stuff", new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2" }
                });

            migrationBuilder.InsertData(
                table: "FeedbackData",
                columns: new[] { "FeedBackID", "Feedback", "FeedbackEmail" },
                values: new object[,]
                {
                    { 1, "I like toast", "RealGuy@RealMail.io" },
                    { 2, "I'm somewhat partial to toast", "MildlyInterestingGuy@RealMail.io" }
                });

            migrationBuilder.InsertData(
                table: "StaticContent",
                columns: new[] { "StaticContentID", "Author", "Content", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "Artyom", "We make stuff", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "About" },
                    { 2, "Greg", "Everything you need to know", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Help" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BusinessContactDetails",
                keyColumn: "BusinessContactID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BusinessContactDetails",
                keyColumn: "BusinessContactID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DynamicContent",
                keyColumn: "DynamicContentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DynamicContent",
                keyColumn: "DynamicContentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FeedbackData",
                keyColumn: "FeedBackID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FeedbackData",
                keyColumn: "FeedBackID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StaticContent",
                keyColumn: "StaticContentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StaticContent",
                keyColumn: "StaticContentID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Author",
                table: "StaticContent");
        }
    }
}
