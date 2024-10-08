﻿// <auto-generated />
using System;
using ChatApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatApp.Data.Migrations
{
    [DbContext(typeof(ChatAppDbContext))]
    [Migration("20240929130921_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("ChatApp.Data.Entities.ChatMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConversationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMessages");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Conversation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.ChatMessage", b =>
                {
                    b.HasOne("ChatApp.Data.Entities.Conversation", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChatApp.Data.Entities.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.Conversation", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("ChatApp.Data.Entities.User", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
