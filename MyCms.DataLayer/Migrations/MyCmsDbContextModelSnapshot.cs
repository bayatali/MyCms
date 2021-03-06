﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCms.DataLayer;

namespace MyCms.DataLayer.Migrations
{
    [DbContext(typeof(MyCmsDbContext))]
    partial class MyCmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyCms.DomainClasses.Page.Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PageGroupGroupID")
                        .HasColumnType("int");

                    b.Property<string>("PageTags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<int>("PageVisit")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<bool>("ShowInSlider")
                        .HasColumnType("bit");

                    b.HasKey("PageID");

                    b.HasIndex("PageGroupGroupID");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("MyCms.DomainClasses.PageGroup.PageGroup", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("GroupID");

                    b.ToTable("PageGroups");
                });

            modelBuilder.Entity("MyCms.DomainClasses.Page.Page", b =>
                {
                    b.HasOne("MyCms.DomainClasses.PageGroup.PageGroup", "PageGroup")
                        .WithMany("Pages")
                        .HasForeignKey("PageGroupGroupID");
                });
#pragma warning restore 612, 618
        }
    }
}
