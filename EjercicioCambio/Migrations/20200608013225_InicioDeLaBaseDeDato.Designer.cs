﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroDeUsuario.DAL;

namespace RegistroDeUsuario.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200608013225_InicioDeLaBaseDeDato")]
    partial class InicioDeLaBaseDeDato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("RegistroDeUsuario.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("contrasena")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombreUsuario")
                        .HasColumnType("TEXT");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
