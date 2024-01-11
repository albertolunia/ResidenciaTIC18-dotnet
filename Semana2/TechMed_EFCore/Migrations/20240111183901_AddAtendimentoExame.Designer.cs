﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechMed_EFCore.Models;

#nullable disable

namespace TechMed_EFCore.Migrations
{
    [DbContext(typeof(TechMedContext))]
    [Migration("20240111183901_AddAtendimentoExame")]
    partial class AddAtendimentoExame
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TechMed_EFCore.Models.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Atendimentos", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AtendimentoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("Exames", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Salario")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Medicos", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pacientes", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Atendimento", b =>
                {
                    b.HasOne("TechMed_EFCore.Models.Medico", "Medico")
                        .WithMany("Atendimentos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechMed_EFCore.Models.Paciente", "Paciente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Exame", b =>
                {
                    b.HasOne("TechMed_EFCore.Models.Atendimento", "Atendimento")
                        .WithMany("Exames")
                        .HasForeignKey("AtendimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Atendimento");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Atendimento", b =>
                {
                    b.Navigation("Exames");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Medico", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Paciente", b =>
                {
                    b.Navigation("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
