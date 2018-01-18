﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RedditFE.Entities;
using System;

namespace RedditFE.Migrations
{
    [DbContext(typeof(HomeContext))]
    partial class HomeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RedditFE.Models.RedditPost", b =>
                {
                    b.Property<long?>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<long?>("RedditUserUserId");

                    b.Property<int>("Score");

                    b.HasKey("PostId");

                    b.HasIndex("RedditUserUserId");

                    b.ToTable("RedditPosts");
                });

            modelBuilder.Entity("RedditFE.Models.RedditUser", b =>
                {
                    b.Property<long?>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserName");

                    b.HasKey("UserId");

                    b.ToTable("RedditUsers");
                });

            modelBuilder.Entity("RedditFE.Models.RedditPost", b =>
                {
                    b.HasOne("RedditFE.Models.RedditUser", "RedditUser")
                        .WithMany("RedditPost")
                        .HasForeignKey("RedditUserUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
