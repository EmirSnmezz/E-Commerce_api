using System;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<Customer>(
                name: "CreatedDate",
                table: "Customers",
                type:"datetime",
                nullable: true,
                defaultValue: DateTime.Now
                );

            migrationBuilder.AddColumn<Customer>(
                name: "UpdatedDate",
                table: "Customers",
                type: "datetime",
                nullable: true,
                defaultValue: DateTime.Now
                );
            migrationBuilder.AddColumn<Category>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime",
                nullable: true,
                defaultValue: DateTime.Now
                );

            migrationBuilder.AddColumn<Category>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime",
                nullable: true,
                defaultValue: DateTime.Now
                );
            migrationBuilder.AddColumn<Product>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime",
                nullable: true,
                defaultValue: DateTime.Now
               );

            migrationBuilder.AddColumn<Product>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime",
                nullable: true,
                defaultValue: DateTime.Now
                );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
