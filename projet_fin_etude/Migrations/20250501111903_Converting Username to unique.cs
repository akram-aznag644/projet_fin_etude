using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projet_fin_etude.Migrations
{
    /// <inheritdoc />
    public partial class ConvertingUsernametounique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CV", "CreatedAt", "EducationLevel", "Email", "FirstName", "HashedPassword", "IsMobile", "JobSearchType", "LastName", "Password", "Phone", "PortfolioLink", "ProfessionalTitle", "Profile", "Role", "UpdatedAt", "UserType", "Username", "YearsOfExperience" },
                values: new object[] { 1, "cv_jane.pdf", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "jane@example.com", "Jane", "hhhhhhhhhhhhhhhhhhhhhhhhhhududuude", true, "Full-time", "Doe", "hhhhhhhhhhh", "1234567890", null, null, "Developer", "JobApplicant", null, "JobApplicant", "janedoe", 3 });
        }
    }
}
