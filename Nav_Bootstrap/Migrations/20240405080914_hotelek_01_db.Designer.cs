﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nav_Bootstrap.Data;

#nullable disable

namespace Nav_Bootstrap.Migrations
{
    [DbContext(typeof(MySQL_DB_Context))]
    [Migration("20240405080914_hotelek_01_db")]
    partial class hotelek_01_db
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Nav_Bootstrap.Modell.PaciHotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("CardorNot")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LovakSzama")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("double");

                    b.HasKey("ID");

                    b.ToTable("PaciHotel");
                });
#pragma warning restore 612, 618
        }
    }
}