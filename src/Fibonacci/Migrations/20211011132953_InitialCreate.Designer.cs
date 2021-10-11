﻿// <auto-generated />
using System;
using Fibonacci;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fibonacci.Migrations
{
    [DbContext(typeof(FibonacciDataContext))]
    [Migration("20211011132953_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fibonacci.TFibonacci", b =>
                {
                    b.Property<Guid>("FibId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FIB_Id")
                        .HasDefaultValueSql("(newid())");

                    b.Property<DateTime>("FibCreatedTimestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("FibInput")
                        .HasColumnType("int")
                        .HasColumnName("FIB_Input");

                    b.Property<long>("FibOutput")
                        .HasColumnType("bigint")
                        .HasColumnName("FIB_Output");

                    b.HasKey("FibId")
                        .HasName("PK_Fibonacci");

                    b.ToTable("T_Fibonacci", "sch_fib");
                });
#pragma warning restore 612, 618
        }
    }
}
