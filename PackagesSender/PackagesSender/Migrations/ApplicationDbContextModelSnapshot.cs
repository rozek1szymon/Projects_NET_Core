﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task1PackagesSender.Data;

namespace Task1PackagesSender.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Task1PackagesSender.Models.Delivery", b =>
                {
                    b.Property<int>("DeliveryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PK_Deliveries")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressOfDestination")
                        .HasColumnName("DEL_AddressOfDestination");

                    b.Property<DateTime>("DateOfMade")
                        .HasColumnName("DEL_DateOfMade");

                    b.Property<string>("NameOfPackage")
                        .HasColumnName("DEL_NameOfPackage");

                    b.Property<int>("PackageID")
                        .HasColumnName("FK_Deliveries_MainPackages");

                    b.Property<double>("WeightOfDelivery")
                        .HasColumnName("DEL_WeightOfDelivery ");

                    b.HasKey("DeliveryID");

                    b.HasIndex("PackageID");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Task1PackagesSender.Models.MainPackage", b =>
                {
                    b.Property<int>("PackageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PK_MainPackages")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateOfCloseThePackage")
                        .HasColumnName("PACK_DateOfCloseThePackage");

                    b.Property<DateTime>("DateOfMadeThePackage")
                        .HasColumnName("PACK_DateOfMadeThePackage");

                    b.Property<string>("DestinationCityOfDelivery")
                        .HasColumnName("PACK_DestinationCityOfDelivery");

                    b.Property<bool>("IsPackageOpen")
                        .HasColumnName("PACK_IsPackageOpen");

                    b.Property<string>("NameOfPackage")
                        .HasColumnName("PACK_NameOfPackage");

                    b.HasKey("PackageID");

                    b.ToTable("MainPackages");
                });

            modelBuilder.Entity("Task1PackagesSender.Models.Delivery", b =>
                {
                    b.HasOne("Task1PackagesSender.Models.MainPackage")
                        .WithMany("Deliveries")
                        .HasForeignKey("PackageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}