﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RecruitmentM.EntityFrameworkCore;
using System;

namespace RecruitmentM.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(RecruitmentMDbContext))]
    [Migration("20171114143132_V4")]
    partial class V4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RecruitmentM.Core.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<string>("Address");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<string>("MailAddress");

                    b.Property<string>("MobileNo");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PhoneNo");

                    b.HasKey("Id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("RecruitmentM.Core.ApplicantWorkflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActionTime");

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("ApplicantId");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("WorkflowId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("WorkflowId");

                    b.ToTable("ApplicantWorkflow");
                });

            modelBuilder.Entity("RecruitmentM.Core.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<int>("ApplicantId");

                    b.Property<string>("CompanyName");

                    b.Property<string>("CompanyWebsite");

                    b.Property<string>("Designation");

                    b.Property<DateTime>("FromDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Projects");

                    b.Property<string>("Technologies");

                    b.Property<DateTime>("ToDate");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("RecruitmentM.Core.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("AddedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("ProcessName");

                    b.Property<int>("ProcessOrder");

                    b.HasKey("Id");

                    b.ToTable("Workflow");
                });

            modelBuilder.Entity("RecruitmentM.Core.ApplicantWorkflow", b =>
                {
                    b.HasOne("RecruitmentM.Core.Applicant", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecruitmentM.Core.Workflow", "Workflow")
                        .WithMany()
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecruitmentM.Core.Experience", b =>
                {
                    b.HasOne("RecruitmentM.Core.Applicant")
                        .WithMany("Experiences")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}