﻿// <auto-generated />
using System;
using Galleass.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Galleass.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190131183852_ShipUpdateMig")]
    partial class ShipUpdateMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Galleass.Models.Cargo", b =>
                {
                    b.Property<int>("CargoId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("PlayerId");

                    b.Property<int>("Quantity");

                    b.Property<int>("TradeGoodId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("CargoId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TradeGoodId");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("Galleass.Models.Discovered", b =>
                {
                    b.Property<int>("DiscoverdId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("GridSquareId");

                    b.Property<int>("PlayerId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("DiscoverdId");

                    b.HasIndex("GridSquareId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Discovereds");
                });

            modelBuilder.Entity("Galleass.Models.GridSquare", b =>
                {
                    b.Property<int>("GridSquareId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("ImageURL");

                    b.Property<int?>("PortId");

                    b.Property<string>("Type");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("xCoord");

                    b.Property<int>("yCoord");

                    b.HasKey("GridSquareId");

                    b.HasIndex("PortId");

                    b.ToTable("GridSquares");
                });

            modelBuilder.Entity("Galleass.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("Crew");

                    b.Property<int>("CrewCondition");

                    b.Property<int>("GridSquareId");

                    b.Property<int>("HullCondition");

                    b.Property<string>("PlayerName");

                    b.Property<int>("RiggingCondition");

                    b.Property<int>("SailsCondition");

                    b.Property<string>("ShipName");

                    b.Property<DateTime>("UpdateAt");

                    b.Property<int>("UserId");

                    b.Property<int>("VesselTypeId");

                    b.Property<int>("Wealth");

                    b.HasKey("PlayerId");

                    b.HasIndex("GridSquareId");

                    b.HasIndex("UserId");

                    b.HasIndex("VesselTypeId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Galleass.Models.Port", b =>
                {
                    b.Property<int>("PortId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("PortImageURL");

                    b.Property<string>("PortName");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("PortId");

                    b.ToTable("Ports");
                });

            modelBuilder.Entity("Galleass.Models.PortPrice", b =>
                {
                    b.Property<int>("PortPriceId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("BuyModifier");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("PortId");

                    b.Property<int>("QuantityAvailable");

                    b.Property<float>("SellModifier");

                    b.Property<int>("TradeGoodId");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("PortPriceId");

                    b.HasIndex("PortId");

                    b.HasIndex("TradeGoodId");

                    b.ToTable("PortPrices");
                });

            modelBuilder.Entity("Galleass.Models.TradeGood", b =>
                {
                    b.Property<int>("TradeGoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<float>("GoodBasePrice");

                    b.Property<string>("GoodImageURL");

                    b.Property<string>("GoodName");

                    b.Property<int>("GoodVolume");

                    b.Property<int>("GoodWeight");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("TradeGoodId");

                    b.ToTable("TradeGoods");
                });

            modelBuilder.Entity("Galleass.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Galleass.Models.VesselType", b =>
                {
                    b.Property<int>("VesselTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CargoSpace");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("MaxCrew");

                    b.Property<int>("MinCrew");

                    b.Property<bool>("Oars");

                    b.Property<int>("TopSpeed");

                    b.Property<string>("TypeName");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("VesselImageURL");

                    b.HasKey("VesselTypeId");

                    b.ToTable("VesselTypes");
                });

            modelBuilder.Entity("Galleass.Models.Cargo", b =>
                {
                    b.HasOne("Galleass.Models.Player", "Player")
                        .WithMany("Cargo")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galleass.Models.TradeGood", "TradeGood")
                        .WithMany("Cargo")
                        .HasForeignKey("TradeGoodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galleass.Models.Discovered", b =>
                {
                    b.HasOne("Galleass.Models.GridSquare", "GridSquare")
                        .WithMany("Discoveries")
                        .HasForeignKey("GridSquareId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galleass.Models.Player", "Player")
                        .WithMany("Discoveries")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galleass.Models.GridSquare", b =>
                {
                    b.HasOne("Galleass.Models.Port", "Port")
                        .WithMany()
                        .HasForeignKey("PortId");
                });

            modelBuilder.Entity("Galleass.Models.Player", b =>
                {
                    b.HasOne("Galleass.Models.GridSquare", "GridSquare")
                        .WithMany("Players")
                        .HasForeignKey("GridSquareId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galleass.Models.User", "User")
                        .WithMany("Players")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galleass.Models.VesselType", "VesselType")
                        .WithMany()
                        .HasForeignKey("VesselTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Galleass.Models.PortPrice", b =>
                {
                    b.HasOne("Galleass.Models.Port", "Port")
                        .WithMany("PortPrices")
                        .HasForeignKey("PortId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Galleass.Models.TradeGood", "TradeGood")
                        .WithMany("PortPrice")
                        .HasForeignKey("TradeGoodId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
