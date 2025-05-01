using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projet_fin_etude.Migrations
{
    /// <inheritdoc />
    public partial class SeedingJobApplicantData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CV", "CreatedAt", "EducationLevel", "Email", "FirstName", "HashedPassword", "IsMobile", "JobSearchType", "LastName", "Password", "Phone", "PortfolioLink", "ProfessionalTitle", "Profile", "Role", "UpdatedAt", "UserType", "Username", "YearsOfExperience" },
                values: new object[] { 1, "cv_jane.pdf", new DateTime(2025, 4, 30, 17, 22, 21, 678, DateTimeKind.Local).AddTicks(3360), null, "jane@example.com", "Jane", "hhhhhhhhhhhhhhhhhhhhhhhhhhududuude", true, "Full-time", "Doe", "hhhhhhhhhhh", "1234567890", null, null, "Developer", "JobApplicant", null, "JobApplicant", "janedoe", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
