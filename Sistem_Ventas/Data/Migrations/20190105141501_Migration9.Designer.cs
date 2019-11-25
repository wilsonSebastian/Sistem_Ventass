﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistem_Ventas.Data;

namespace Sistem_Ventas.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190105141501_Migration9")]
    partial class Migration9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Clientes.Models.TClientes", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Creditos");

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("NID")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("TClientes");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Clientes.Models.TCreditos", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creditos");

                    b.HasKey("ID");

                    b.ToTable("TCreditos");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Clientes.Models.TReportes_clientes", b =>
                {
                    b.Property<int>("ReportesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Deuda");

                    b.Property<DateTime>("FechaDeuda");

                    b.Property<DateTime>("FechaPago");

                    b.Property<string>("Pago");

                    b.Property<int?>("TClientesID");

                    b.Property<string>("Ticket");

                    b.HasKey("ReportesID");

                    b.HasIndex("TClientesID");

                    b.ToTable("TReportes_clientes");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Compras.Models.TCompras", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Codigo");

                    b.Property<bool>("Credito");

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.Property<int>("Dia");

                    b.Property<string>("Email");

                    b.Property<string>("Fecha");

                    b.Property<int>("IdProveedor");

                    b.Property<string>("IdUsuario");

                    b.Property<string>("Importe");

                    b.Property<string>("Mes");

                    b.Property<string>("Precio")
                        .IsRequired();

                    b.Property<string>("Proveedor");

                    b.Property<string>("Role");

                    b.Property<string>("Usuario");

                    b.Property<string>("Year");

                    b.HasKey("ID");

                    b.ToTable("TCompras");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Compras.Models.TCompras_temp", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Codigo");

                    b.Property<bool>("Credito");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Email");

                    b.Property<string>("Fecha");

                    b.Property<int>("IdProveedor");

                    b.Property<string>("Importe");

                    b.Property<string>("Precio");

                    b.Property<string>("Proveedor");

                    b.HasKey("ID");

                    b.ToTable("TCompras_temp");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Proveedores.Models.TProveedores", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Proveedor")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("TProveedores");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Proveedores.Models.TReportes_proveedores", b =>
                {
                    b.Property<int>("ReportesID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Deuda");

                    b.Property<DateTime>("FechaDeuda");

                    b.Property<DateTime>("FechaPago");

                    b.Property<string>("Pago");

                    b.Property<int?>("TProveedoresID");

                    b.Property<string>("Ticket");

                    b.HasKey("ReportesID");

                    b.HasIndex("TProveedoresID");

                    b.ToTable("TReportes_proveedores");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Usuarios.Models.TUsuarios", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido");

                    b.Property<string>("IdUser");

                    b.Property<string>("Imagen");

                    b.Property<string>("NID");

                    b.Property<string>("Nombre");

                    b.HasKey("ID");

                    b.ToTable("TUsuarios");
                });

            modelBuilder.Entity("Sistem_Ventas.Models.TTickets", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Deuda");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FechaDeuda");

                    b.Property<DateTime>("FechaPago");

                    b.Property<string>("Pago");

                    b.Property<string>("Propietario");

                    b.Property<string>("Ticket");

                    b.HasKey("ID");

                    b.ToTable("TTickets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Clientes.Models.TReportes_clientes", b =>
                {
                    b.HasOne("Sistem_Ventas.Areas.Clientes.Models.TClientes", "TClientes")
                        .WithMany("TReportes_clientes")
                        .HasForeignKey("TClientesID");
                });

            modelBuilder.Entity("Sistem_Ventas.Areas.Proveedores.Models.TReportes_proveedores", b =>
                {
                    b.HasOne("Sistem_Ventas.Areas.Proveedores.Models.TProveedores", "TProveedores")
                        .WithMany("TReportes_proveedores")
                        .HasForeignKey("TProveedoresID");
                });
#pragma warning restore 612, 618
        }
    }
}
