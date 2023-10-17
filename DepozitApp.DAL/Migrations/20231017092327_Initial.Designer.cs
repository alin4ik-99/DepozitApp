﻿// <auto-generated />
using DepozitApp.DAL.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DepozitApp.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231017092327_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepozitApp.DAL.Entities.MounthlyDepozitReport", b =>
                {
                    b.Property<int>("MounthId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MounthId"));

                    b.Property<double>("MounthDepozit")
                        .HasColumnType("float");

                    b.Property<double>("MounthlyIncome")
                        .HasColumnType("float");

                    b.Property<double>("MounthlyPlus")
                        .HasColumnType("float");

                    b.Property<int>("NumberMounth")
                        .HasColumnType("int");

                    b.HasKey("MounthId");

                    b.ToTable("MounthlyDepozitReports");
                });
#pragma warning restore 612, 618
        }
    }
}
