﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AngularAuthYtAPI.Migrations
{
    public partial class ALL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppliedJobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppliedJobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false),
                    AppliedUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliedJobs", x => x.JobId);
                    table.ForeignKey(
                        name: "FK_AppliedJobs_job_JobId",
                        column: x => x.JobId,
                        principalTable: "job",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
