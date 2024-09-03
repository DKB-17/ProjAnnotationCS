﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjAnnotation.Models;

#nullable disable

namespace ProjAnnotation.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjAnnotation.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("aniversario")
                        .HasColumnType("datetime2");

                    b.Property<int>("cursoID")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("periodo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("cursoID");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("ProjAnnotation.Models.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("alunoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("salaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("alunoId");

                    b.HasIndex("salaId");

                    b.ToTable("Atendimentos");
                });

            modelBuilder.Entity("ProjAnnotation.Models.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ProjAnnotation.Models.Sala", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("equipamentos")
                        .HasColumnType("int");

                    b.Property<int>("situação")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Salas");
                });

            modelBuilder.Entity("ProjAnnotation.Models.Aluno", b =>
                {
                    b.HasOne("ProjAnnotation.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });

            modelBuilder.Entity("ProjAnnotation.Models.Atendimento", b =>
                {
                    b.HasOne("ProjAnnotation.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjAnnotation.Models.Sala", "sala")
                        .WithMany()
                        .HasForeignKey("salaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("sala");
                });
#pragma warning restore 612, 618
        }
    }
}
