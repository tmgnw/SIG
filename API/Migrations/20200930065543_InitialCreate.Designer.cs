﻿// <auto-generated />
using System;
using API.MyContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200930065543_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Model.Barang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("Jenis_Id");

                    b.Property<string>("Nama_Barang");

                    b.Property<int>("Stok");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("Jenis_Id");

                    b.ToTable("TB_Barang");
                });

            modelBuilder.Entity("API.Model.JenisBarang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Jenis_Barang");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("TB_JenisBarang");
                });

            modelBuilder.Entity("API.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Role");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("TB_User");
                });

            modelBuilder.Entity("API.Model.Barang", b =>
                {
                    b.HasOne("API.Model.JenisBarang", "JenisBarang")
                        .WithMany()
                        .HasForeignKey("Jenis_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
