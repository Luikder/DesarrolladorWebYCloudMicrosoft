﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Underwater.Data;

namespace Underwater.Migrations
{
    [DbContext(typeof(UnderwaterContext))]
    [Migration("20201218160042_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Underwater.Models.Aquarium", b =>
                {
                    b.Property<int>("AquariumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<bool>("Open");

                    b.HasKey("AquariumId");

                    b.ToTable("Aquariums");

                    b.HasData(
                        new { AquariumId = 1, Address = "4121  Broadway Street", Name = "Fish Aquarium", Number = -337, Open = true },
                        new { AquariumId = 2, Address = "3219  Central Avenue", Name = "Ocean Aquarium", Number = -1298, Open = false },
                        new { AquariumId = 3, Address = "128  Stewart Street", Name = "Best Aquarium", Number = -6695, Open = true }
                    );
                });

            modelBuilder.Entity("Underwater.Models.Fish", b =>
                {
                    b.Property<int>("FishId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AquariumId");

                    b.Property<string>("ImageMimeType");

                    b.Property<string>("ImageName");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PhotoFile");

                    b.Property<string>("ScientificName");

                    b.HasKey("FishId");

                    b.HasIndex("AquariumId");

                    b.ToTable("fishes");

                    b.HasData(
                        new { FishId = 1, AquariumId = 1, ImageMimeType = "image/jpeg", ImageName = "goldfish.jpg", Name = "Goldfish", ScientificName = "Carassius auratus" },
                        new { FishId = 2, AquariumId = 1, ImageMimeType = "image/jpeg", ImageName = "starfish.jpg", Name = "Starfish", ScientificName = "Asteroidea" },
                        new { FishId = 3, AquariumId = 1, ImageMimeType = "image/jpeg", ImageName = "clownfish.jpg", Name = "Clownfish", ScientificName = "Amphiprion ocellaris" }
                    );
                });

            modelBuilder.Entity("Underwater.Models.Fish", b =>
                {
                    b.HasOne("Underwater.Models.Aquarium", "Aquarium")
                        .WithMany("Fishes")
                        .HasForeignKey("AquariumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
