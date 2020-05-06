﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(UserDBContext))]
    [Migration("20200506042849_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.ModelCLasses.BookModel", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Availability");

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Price");

                    b.Property<string>("Ratings");

                    b.Property<string>("Review");

                    b.Property<string>("Title");

                    b.HasKey("BookId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Model.ModelCLasses.CartModel", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Authors");

                    b.Property<int>("Count");

                    b.Property<string>("Image");

                    b.Property<double>("Price");

                    b.Property<string>("Title");

                    b.Property<double>("TotalPrice");

                    b.HasKey("CartId");

                    b.ToTable("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
