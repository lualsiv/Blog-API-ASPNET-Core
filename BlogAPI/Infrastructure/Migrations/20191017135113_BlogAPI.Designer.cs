﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191017135113_BlogAPI")]
    partial class BlogAPI
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Domain.Entities.Category.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.HasKey("CategoryId");

                    b.ToTable("Category","Blog");
                });

            modelBuilder.Entity("Domain.Entities.Comment.Comment", b =>
                {
                    b.Property<Guid>("IdComment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("character varying(140)")
                        .HasMaxLength(140);

                    b.HasKey("IdComment");

                    b.ToTable("TBL_Comment","Blog");
                });

            modelBuilder.Entity("Domain.Entities.Post.Post", b =>
                {
                    b.Property<Guid>("IdPost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("character varying(1500)")
                        .HasMaxLength(1500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("character varying(60)")
                        .HasMaxLength(60);

                    b.HasKey("IdPost");

                    b.ToTable("Post","Blog");

                    b.HasData(
                        new
                        {
                            IdPost = new Guid("3e0e738a-6c38-4df1-a42a-0e1ad2e0ce79"),
                            CreationDate = new DateTime(2019, 10, 17, 10, 51, 12, 846, DateTimeKind.Local).AddTicks(763),
                            Description = "Outra string",
                            Title = "Aula de docker"
                        },
                        new
                        {
                            IdPost = new Guid("eb4bd2c0-dd33-4b74-8286-4915e6798fff"),
                            CreationDate = new DateTime(2019, 10, 17, 10, 51, 12, 850, DateTimeKind.Local).AddTicks(9827),
                            Description = "GoF e a melhor equipe que tem",
                            Title = "Equipe Gang of Five"
                        },
                        new
                        {
                            IdPost = new Guid("0961e950-c2eb-4bda-a3af-8ada74de8506"),
                            CreationDate = new DateTime(2019, 10, 17, 10, 51, 12, 850, DateTimeKind.Local).AddTicks(9922),
                            Description = "GoF e a melhor equipe que tem",
                            Title = "Equipe Gang of Five"
                        },
                        new
                        {
                            IdPost = new Guid("59dc189a-564e-49d0-8d59-51b8642373ca"),
                            CreationDate = new DateTime(2019, 10, 17, 10, 51, 12, 850, DateTimeKind.Local).AddTicks(9934),
                            Description = "Prometemos entregar o banco",
                            Title = "Equipe que prometeu"
                        });
                });

            modelBuilder.Entity("Domain.Entities.User.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("IdUser");

                    b.ToTable("TBL_User","Blog");
                });
#pragma warning restore 612, 618
        }
    }
}