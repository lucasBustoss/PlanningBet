﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PlanningBet.Bets.API.Database;

#nullable disable

namespace PlanningBet.Bets.API.Migrations
{
    [DbContext(typeof(BetsDbContext))]
    partial class BetsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PlanningBet.Bets.API.Models.Entity.BetEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("BetId")
                        .HasColumnType("text");

                    b.Property<string>("EventCode")
                        .HasColumnType("text");

                    b.Property<Guid>("EventId")
                        .HasColumnType("uuid");

                    b.Property<string>("MarketDescription")
                        .HasColumnType("text");

                    b.Property<string>("MarketId")
                        .HasColumnType("text");

                    b.Property<int>("MarketType")
                        .HasColumnType("integer");

                    b.Property<decimal>("OddMatched")
                        .HasColumnType("numeric");

                    b.Property<decimal>("OddRequest")
                        .HasColumnType("numeric");

                    b.Property<Guid>("PickTeamId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("PlacedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("PriceSettled")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Profit")
                        .HasColumnType("numeric");

                    b.Property<int>("SelectionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SettledDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Side")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("PlanningBet.Bets.API.Models.Entity.EventEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AwayTeamId")
                        .HasColumnType("uuid");

                    b.Property<int>("BetCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("Commission")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventCode")
                        .HasColumnType("text");

                    b.Property<Guid>("HomeTeamId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("Profit")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
