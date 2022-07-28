using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataBase.Migrations
{
    public partial class startup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accessories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainCity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cities_cities_MainCity",
                        column: x => x.MainCity,
                        principalTable: "cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "dateTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studyBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studyBranches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "timeSlotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    slote = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeSlotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                    table.ForeignKey(
                        name: "FK_user_role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "unitStores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitStores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_unitStores_user_UserFk",
                        column: x => x.UserFk,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "storeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AccessoryId = table.Column<int>(type: "int", nullable: false),
                    UnitStoreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_storeDetails_accessories_AccessoryId",
                        column: x => x.AccessoryId,
                        principalTable: "accessories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_storeDetails_unitStores_UnitStoreId",
                        column: x => x.UnitStoreId,
                        principalTable: "unitStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "units",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    UserFk = table.Column<int>(type: "int", nullable: false),
                    UnitStoreFk = table.Column<int>(type: "int", nullable: false),
                    StudyBranchEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_units", x => x.Id);
                    table.ForeignKey(
                        name: "FK_units_studyBranches_StudyBranchEntityId",
                        column: x => x.StudyBranchEntityId,
                        principalTable: "studyBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_units_unitStores_UnitStoreFk",
                        column: x => x.UnitStoreFk,
                        principalTable: "unitStores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_units_user_UserFk",
                        column: x => x.UserFk,
                        principalTable: "user",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "unitRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentCount = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unitRooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_unitRooms_rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_unitRooms_units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniversityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Recorded = table.Column<bool>(type: "bit", nullable: false),
                    UnitRoomFk = table.Column<int>(type: "int", nullable: false),
                    StudyBranchId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_cities_CityId",
                        column: x => x.CityId,
                        principalTable: "cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_studyBranches_StudyBranchId",
                        column: x => x.StudyBranchId,
                        principalTable: "studyBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_students_unitRooms_UnitRoomFk",
                        column: x => x.UnitRoomFk,
                        principalTable: "unitRooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "studentAccessories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Returned = table.Column<bool>(type: "bit", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StoreDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentAccessories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentAccessories_storeDetails_StoreDetailId",
                        column: x => x.StoreDetailId,
                        principalTable: "storeDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentAccessories_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "studentDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    TimeSloteId = table.Column<int>(type: "int", nullable: false),
                    DateTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentDates_dateTypes_DateTypeId",
                        column: x => x.DateTypeId,
                        principalTable: "dateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentDates_students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_studentDates_timeSlotes_TimeSloteId",
                        column: x => x.TimeSloteId,
                        principalTable: "timeSlotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cities_MainCity",
                table: "cities",
                column: "MainCity");

            migrationBuilder.CreateIndex(
                name: "IX_storeDetails_AccessoryId",
                table: "storeDetails",
                column: "AccessoryId");

            migrationBuilder.CreateIndex(
                name: "IX_storeDetails_UnitStoreId",
                table: "storeDetails",
                column: "UnitStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_studentAccessories_StoreDetailId",
                table: "studentAccessories",
                column: "StoreDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_studentAccessories_StudentId",
                table: "studentAccessories",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentDates_DateTypeId",
                table: "studentDates",
                column: "DateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_studentDates_StudentId",
                table: "studentDates",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_studentDates_TimeSloteId",
                table: "studentDates",
                column: "TimeSloteId");

            migrationBuilder.CreateIndex(
                name: "IX_students_CityId",
                table: "students",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_students_StudyBranchId",
                table: "students",
                column: "StudyBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_students_UnitRoomFk",
                table: "students",
                column: "UnitRoomFk");

            migrationBuilder.CreateIndex(
                name: "IX_unitRooms_RoomId",
                table: "unitRooms",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_unitRooms_UnitId",
                table: "unitRooms",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_units_StudyBranchEntityId",
                table: "units",
                column: "StudyBranchEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_units_UnitStoreFk",
                table: "units",
                column: "UnitStoreFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_units_UserFk",
                table: "units",
                column: "UserFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_unitStores_UserFk",
                table: "unitStores",
                column: "UserFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_RoleId",
                table: "user",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "studentAccessories");

            migrationBuilder.DropTable(
                name: "studentDates");

            migrationBuilder.DropTable(
                name: "storeDetails");

            migrationBuilder.DropTable(
                name: "dateTypes");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "timeSlotes");

            migrationBuilder.DropTable(
                name: "accessories");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "unitRooms");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "units");

            migrationBuilder.DropTable(
                name: "studyBranches");

            migrationBuilder.DropTable(
                name: "unitStores");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "role");
        }
    }
}
