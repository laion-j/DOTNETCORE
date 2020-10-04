﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProAgil.api.Data;

namespace ProAgil.api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201003033744_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("ProAgil.api.Model.Evento", b =>
                {
                    b.Property<int>("EventoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DataEvento");

                    b.Property<string>("Local");

                    b.Property<string>("Lote");

                    b.Property<int>("QtdPessoas");

                    b.Property<string>("Tema");

                    b.HasKey("EventoID");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}
