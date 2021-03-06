﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SetupDatabase;
using ow.Framework.Database.Characters;
using ow.Framework.Database.Storages;

namespace SetupDatabase.Migrations
{
    [DbContext(typeof(MigrationContext))]
    [Migration("20201209092235_12_09_20_4")]
    partial class _12_09_20_4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("ow.Framework.Database.AccouintPosts.AccountPostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("account_posts");
                });

            modelBuilder.Entity("ow.Framework.Database.Accounts.AccountModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("LastSelectedCharacterId")
                        .HasColumnType("integer");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("character varying(24)");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<decimal>("SoulCash")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("Nickname")
                        .IsUnique();

                    b.ToTable("accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastSelectedCharacterId = -1,
                            Nickname = "sawich",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        },
                        new
                        {
                            Id = 2,
                            LastSelectedCharacterId = -1,
                            Nickname = "Leeroy",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        },
                        new
                        {
                            Id = 3,
                            LastSelectedCharacterId = -1,
                            Nickname = "Tweekly",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        },
                        new
                        {
                            Id = 4,
                            LastSelectedCharacterId = -1,
                            Nickname = "Chelsea",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        },
                        new
                        {
                            Id = 5,
                            LastSelectedCharacterId = -1,
                            Nickname = "Dez",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        },
                        new
                        {
                            Id = 6,
                            LastSelectedCharacterId = -1,
                            Nickname = "Godo",
                            Password = new byte[] { 85, 165, 86, 15, 55, 213, 63, 202, 45, 212, 222, 16, 50, 189, 195, 225, 180, 162, 114, 124, 92, 175, 112, 216, 10, 215, 203, 48, 247, 21, 175, 175, 228, 21, 179, 235, 218, 60, 112, 218, 130, 134, 115, 78, 84, 169, 234, 143, 2, 230, 79, 161, 26, 114, 50, 30, 54, 112, 179, 90, 221, 191, 60, 250 },
                            SoulCash = 0m
                        });
                });

            modelBuilder.Entity("ow.Framework.Database.CharacterPosts.CharacterPostModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("character_posts");
                });

            modelBuilder.Entity("ow.Framework.Database.Characters.CharacterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("integer");

                    b.Property<byte>("Advancement")
                        .HasColumnType("smallint");

                    b.Property<AppearanceModel>("Appearance")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<BankModel>("Bank")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<EnergyModel>("Energy")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<decimal>("Exp")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GateId")
                        .HasColumnType("integer");

                    b.Property<byte>("Hero")
                        .HasColumnType("smallint");

                    b.Property<InventoryModel>("Inventory")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<long[]>("LearnedSkill")
                        .IsRequired()
                        .HasColumnType("bigint[]");

                    b.Property<byte>("Level")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<PlaceModel>("Place")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<long>("PortraitId")
                        .HasColumnType("bigint");

                    b.Property<ProfileModel>("Profile")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<long[]>("QuickSlot")
                        .IsRequired()
                        .HasColumnType("bigint[]");

                    b.Property<byte>("SlotId")
                        .HasColumnType("smallint");

                    b.Property<StorageModel[]>("Storage")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<TitleModel>("Title")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("characters");
                });

            modelBuilder.Entity("ow.Framework.Database.Guilds.GuildModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("character varying(1024)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.HasKey("Id");

                    b.ToTable("guilds");
                });

            modelBuilder.Entity("ow.Framework.Database.Storages.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("BroochSlots")
                        .IsRequired()
                        .HasColumnType("char(15)");

                    b.Property<int>("CharacterId")
                        .HasColumnType("integer");

                    b.Property<long>("Color")
                        .HasColumnType("bigint");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<byte>("Durability")
                        .HasColumnType("smallint");

                    b.Property<long>("DyeColor")
                        .HasColumnType("bigint");

                    b.Property<long>("PrototypeId")
                        .HasColumnType("bigint");

                    b.Property<byte>("Quantly")
                        .HasColumnType("smallint");

                    b.Property<int>("SlotId")
                        .HasColumnType("integer");

                    b.Property<byte>("Slots")
                        .HasColumnType("smallint");

                    b.Property<StatModel[]>("Stats")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.Property<int>("StorageType")
                        .HasColumnType("integer");

                    b.Property<long>("TagId")
                        .HasColumnType("bigint");

                    b.Property<UpgradeModel>("Upgrade")
                        .IsRequired()
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("items");
                });

            modelBuilder.Entity("ow.Framework.Database.AccouintPosts.AccountPostModel", b =>
                {
                    b.HasOne("ow.Framework.Database.Accounts.AccountModel", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ow.Framework.Database.CharacterPosts.CharacterPostModel", b =>
                {
                    b.HasOne("ow.Framework.Database.Characters.CharacterModel", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });

            modelBuilder.Entity("ow.Framework.Database.Characters.CharacterModel", b =>
                {
                    b.HasOne("ow.Framework.Database.Accounts.AccountModel", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("ow.Framework.Database.Storages.ItemModel", b =>
                {
                    b.HasOne("ow.Framework.Database.Characters.CharacterModel", "Character")
                        .WithMany()
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
