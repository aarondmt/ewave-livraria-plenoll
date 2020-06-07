﻿// <auto-generated />
using System;
using Livraria.v1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.v1.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200607185608_AdicionarDataDevolvido")]
    partial class AdicionarDataDevolvido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.v1.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<DateTime?>("DataDevolucao");

                    b.Property<DateTime?>("DataDevolvido");

                    b.Property<DateTime>("DataEmprestimo");

                    b.Property<int>("LivroId");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("LivroId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("Livraria.v1.Models.InstituicaoEnsino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cnpj")
                        .IsRequired();

                    b.Property<string>("Endereco")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("InstituicaoEnsino");
                });

            modelBuilder.Entity("Livraria.v1.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Autor")
                        .IsRequired();

                    b.Property<string>("Genero")
                        .IsRequired();

                    b.Property<string>("Sinopse");

                    b.Property<string>("Titulo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("Livraria.v1.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("Endereco")
                        .IsRequired();

                    b.Property<int>("InstituicaoEnsinoId");

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("InstituicaoEnsinoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Livraria.v1.Models.Emprestimo", b =>
                {
                    b.HasOne("Livraria.v1.Models.Livro", "Livro")
                        .WithMany("Emprestimos")
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Livraria.v1.Models.Usuario", "Usuario")
                        .WithMany("Emprestimos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Livraria.v1.Models.Usuario", b =>
                {
                    b.HasOne("Livraria.v1.Models.InstituicaoEnsino", "InstituicaoEnsino")
                        .WithMany()
                        .HasForeignKey("InstituicaoEnsinoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
