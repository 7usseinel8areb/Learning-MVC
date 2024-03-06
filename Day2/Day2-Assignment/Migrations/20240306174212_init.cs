using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day2_Assignment.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    minDegree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Department_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Course_Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade); // Set cascade behavior to Cascade
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Department_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Trainee_Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade); // Set cascade behavior to Cascade
                });

            migrationBuilder.CreateTable(
                name: "Instructor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department_ID = table.Column<int>(type: "int", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructor_Course_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict); // Set cascade behavior to Restrict
                    table.ForeignKey(
                        name: "FK_Instructor_Department_Department_ID",
                        column: x => x.Department_ID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict); // Set cascade behavior to Restrict
                });

            migrationBuilder.CreateTable(
                name: "crsResult",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    degree = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Course_ID = table.Column<int>(type: "int", nullable: false),
                    Trainee_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crsResult", x => x.ID);
                    table.ForeignKey(
                        name: "FK_crsResult_Course_Course_ID",
                        column: x => x.Course_ID,
                        principalTable: "Course",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict); // Set cascade behavior to Restrict
                    table.ForeignKey(
                        name: "FK_crsResult_Trainee_Trainee_ID",
                        column: x => x.Trainee_ID,
                        principalTable: "Trainee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict); // Set cascade behavior to Restrict
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Department_ID",
                table: "Course",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_crsResult_Course_ID",
                table: "crsResult",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_crsResult_Trainee_ID",
                table: "crsResult",
                column: "Trainee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Course_ID",
                table: "Instructor",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Department_ID",
                table: "Instructor",
                column: "Department_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_Department_ID",
                table: "Trainee",
                column: "Department_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "crsResult");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
