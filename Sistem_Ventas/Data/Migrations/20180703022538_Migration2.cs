﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistem_Ventas.Data.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //   name: "TUsuarios",
            //   columns: table => new
            //   {
            //       ID = table.Column<int>(nullable: false)
            //           .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //       Nombre = table.Column<string>(nullable: true),
            //       Apellido = table.Column<string>(nullable: true),
            //       NID = table.Column<string>(nullable: true),
            //       Imagen = table.Column<string>(nullable: true),
            //       IdUser = table.Column<string>(nullable: true)
            //   },
            //   constraints: table =>
            //   {
            //       table.PrimaryKey("PK_TUsuarios", x => x.ID);
            //   });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
