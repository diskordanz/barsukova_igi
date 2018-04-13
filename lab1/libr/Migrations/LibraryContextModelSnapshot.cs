﻿// <auto-generated />
using libr;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace libr.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("libr.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<string>("Edition");

                    b.Property<int?>("JenreID");

                    b.Property<string>("Name");

                    b.Property<float>("Price");

                    b.Property<int>("RegistrationNumber");

                    b.Property<int>("YearOfEdition");

                    b.HasKey("ID");

                    b.HasIndex("JenreID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("libr.Models.Issuence", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BookID");

                    b.Property<DateTime>("DateOfIssuance");

                    b.Property<DateTime>("DateOfReturn");

                    b.Property<int?>("ReaderID");

                    b.Property<bool>("Return");

                    b.HasKey("ID");

                    b.HasIndex("BookID");

                    b.HasIndex("ReaderID");

                    b.ToTable("Issuances");
                });

            modelBuilder.Entity("libr.Models.Jenre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Jenres");
                });

            modelBuilder.Entity("libr.Models.Reader", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adres");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FullName");

                    b.Property<string>("PassportData");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Sex");

                    b.HasKey("ID");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("libr.Models.Book", b =>
                {
                    b.HasOne("libr.Models.Jenre", "Jenre")
                        .WithMany()
                        .HasForeignKey("JenreID");
                });

            modelBuilder.Entity("libr.Models.Issuence", b =>
                {
                    b.HasOne("libr.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookID");

                    b.HasOne("libr.Models.Reader", "Reader")
                        .WithMany()
                        .HasForeignKey("ReaderID");
                });
#pragma warning restore 612, 618
        }
    }
}