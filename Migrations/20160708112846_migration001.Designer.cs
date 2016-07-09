using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ConsoleApplication;

namespace hwapp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20160708112846_migration001")]
    partial class migration001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("ConsoleApplication.Configuration", b =>
                {
                    b.Property<string>("Key");

                    b.Property<string>("Value");

                    b.HasKey("Key");

                    b.ToTable("Core_Configuration");
                });
        }
    }
}
