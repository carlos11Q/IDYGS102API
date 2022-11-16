﻿// <auto-generated />
using IDYGS102API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IDYGS102API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Modelos.Genero", b =>
                {
                    b.Property<int>("PkGenero")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkGenero");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("Domain.Modelos.Personaje", b =>
                {
                    b.Property<int>("PkPersonaje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FkGenero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poder")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PkPersonaje");

                    b.HasIndex("FkGenero");

                    b.ToTable("personajes");
                });

            modelBuilder.Entity("Domain.Modelos.Personaje", b =>
                {
                    b.HasOne("Domain.Modelos.Genero", "genero")
                        .WithMany()
                        .HasForeignKey("FkGenero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genero");
                });
#pragma warning restore 612, 618
        }
    }
}
