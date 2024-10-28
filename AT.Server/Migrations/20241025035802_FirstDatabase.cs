﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AT.Server.Migrations
{
    /// <inheritdoc />
    public partial class FirstDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AlterDatabase()
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoles",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoles", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        PasswordHash = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
            //        LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
            //        AccessFailedCount = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUsers", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "GroupUsers",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        GroupName = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        CreatedBy = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        UpdatedBy = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GroupUsers", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Progresses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ProjectTypeId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Progresses", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "ProjectTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ProjectTypes", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Staffs",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        UserId = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        GroupUserId = table.Column<int>(type: "int", nullable: false),
            //        DepartmentId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Staffs", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "Tasks",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        OrderCode = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        StaffId = table.Column<int>(type: "int", nullable: false),
            //        StaffName = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        DateStart = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        DateFinish = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        DueDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
            //        Status = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Progress = table.Column<string>(type: "longtext", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tasks", x => x.Id);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetRoleClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        ClaimType = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimValue = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserClaims",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //        UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        ClaimType = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ClaimValue = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserLogins",
            //    columns: table => new
            //    {
            //        LoginProvider = table.Column<string>(type: "varchar(95)", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ProviderKey = table.Column<string>(type: "varchar(95)", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserRoles",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        RoleId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "AspNetRoles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_AspNetUserRoles_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

            //migrationBuilder.CreateTable(
            //    name: "AspNetUserTokens",
            //    columns: table => new
            //    {
            //        UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
            //        LoginProvider = table.Column<string>(type: "varchar(95)", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Name = table.Column<string>(type: "varchar(95)", nullable: false)
            //            .Annotation("MySql:CharSet", "utf8mb4"),
            //        Value = table.Column<string>(type: "longtext", nullable: true)
            //            .Annotation("MySql:CharSet", "utf8mb4")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
            //        table.ForeignKey(
            //            name: "FK_AspNetUserTokens_AspNetUsers_UserId",
            //            column: x => x.UserId,
            //            principalTable: "AspNetUsers",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    })
            //    .Annotation("MySql:CharSet", "utf8mb4");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_RoleId",
        //        table: "AspNetRoleClaims",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "RoleNameIndex",
        //        table: "AspNetRoles",
        //        column: "NormalizedName",
        //        unique: true);

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserClaims_UserId",
        //        table: "AspNetUserClaims",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_UserId",
        //        table: "AspNetUserLogins",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_RoleId",
        //        table: "AspNetUserRoles",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "EmailIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedEmail");

        //    migrationBuilder.CreateIndex(
        //        name: "UserNameIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedUserName",
        //        unique: true);
        //}

        ///// <inheritdoc />
        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "AspNetRoleClaims");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserClaims");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserLogins");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserRoles");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUserTokens");

        //    migrationBuilder.DropTable(
        //        name: "Departments");

        //    migrationBuilder.DropTable(
        //        name: "GroupUsers");

        //    migrationBuilder.DropTable(
        //        name: "Progresses");

        //    migrationBuilder.DropTable(
        //        name: "ProjectTypes");

        //    migrationBuilder.DropTable(
        //        name: "Staffs");

        //    migrationBuilder.DropTable(
        //        name: "Tasks");

        //    migrationBuilder.DropTable(
        //        name: "AspNetRoles");

        //    migrationBuilder.DropTable(
        //        name: "AspNetUsers");
        }
    }
}
