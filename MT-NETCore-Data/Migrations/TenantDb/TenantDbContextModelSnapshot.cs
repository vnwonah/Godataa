﻿// <auto-generated />
using System;
using MT_NetCore_Data.TenantsDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT_NetCore_Data.Migrations.TenantDb
{
    [DbContext(typeof(TenantDbContext))]
    partial class TenantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT_NetCore_Data.Entities.Form", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<string>("FormJson");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name");

                    b.Property<long>("NumberOFApprovedSubmissions");

                    b.Property<long>("NumberOFSubmissions");

                    b.Property<long>("NumberOFUnApprovedSubmissions");

                    b.Property<string>("ProjectId");

                    b.Property<string>("Title");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Location", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<string>("FormId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("State");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Project", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name");

                    b.Property<string>("TeamId");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Submission", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<byte[]>("FormId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LocationId");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("SubmissionJson");

                    b.Property<long>("SubmissionPosition");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Team", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Currency");

                    b.Property<string>("CustomerAquisition");

                    b.Property<string>("CustomerSubscriptionID");

                    b.Property<DateTime>("DatePaid");

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<bool>("DisplayCampaignTab");

                    b.Property<bool>("DisplayReportTab");

                    b.Property<string>("Industry");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastApiTimestamp");

                    b.Property<string>("LogoLink");

                    b.Property<long>("MaxForms");

                    b.Property<long>("MaxRecord");

                    b.Property<long>("MaxRecordsPerMth");

                    b.Property<long>("MaxUsers");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Name");

                    b.Property<DateTime>("NextSubscriptionDate");

                    b.Property<string>("OfflineId");

                    b.Property<DateTime>("PaymentLastApiTimestamp");

                    b.Property<long>("RecordsThisMth");

                    b.Property<long>("RecordsThisYear");

                    b.Property<DateTime>("ResetDate");

                    b.Property<string>("SubscriptionID");

                    b.Property<string>("TeamSize");

                    b.Property<string>("Team_Ref");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("BVNNumber");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset?>("DeletedAt");

                    b.Property<string>("FirstName");

                    b.Property<string>("FormId");

                    b.Property<string>("Gender");

                    b.Property<string>("IdString");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName");

                    b.Property<DateTimeOffset?>("ModifiedAt")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("PhotoString");

                    b.Property<string>("PrimaryLocationId");

                    b.Property<string>("ProjectId");

                    b.Property<string>("SecondaryLocationId");

                    b.Property<string>("TeamId");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.HasIndex("PrimaryLocationId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SecondaryLocationId");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Form", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Project")
                        .WithMany("Forms")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Location", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Form")
                        .WithMany("CollectionLocations")
                        .HasForeignKey("FormId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Project", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Team")
                        .WithMany("Projects")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Submission", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.User", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Form")
                        .WithMany("Supervisors")
                        .HasForeignKey("FormId");

                    b.HasOne("MT_NetCore_Data.Entities.Location", "PrimaryLocation")
                        .WithMany()
                        .HasForeignKey("PrimaryLocationId");

                    b.HasOne("MT_NetCore_Data.Entities.Project")
                        .WithMany("Users")
                        .HasForeignKey("ProjectId");

                    b.HasOne("MT_NetCore_Data.Entities.Location", "SecondaryLocation")
                        .WithMany()
                        .HasForeignKey("SecondaryLocationId");

                    b.HasOne("MT_NetCore_Data.Entities.Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
