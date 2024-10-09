﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projet_Boutique.DAL.DataBase;

#nullable disable

namespace Projet_Boutique.DAL.Migrations
{
    [DbContext(typeof(BoutiqueContext))]
    partial class BoutiqueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Category");

                    b.HasIndex("ProductId");

                    b.ToTable("Categorie", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Électronique"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Appareils ménagers"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Accessoires"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Informatique"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Gaming"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Électroménager"
                        });
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.CategoryProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Categorie_Produit_NN", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 5
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 6
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 4
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 6
                        });
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Format", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_Format");

                    b.ToTable("Format", (string)null);
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.FormatProduct", b =>
                {
                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("FormatId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Format_Produit_NN", (string)null);
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Amount")
                        .HasColumnType("real");

                    b.Property<int>("OrderUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id")
                        .HasName("PK_Order");

                    b.HasIndex("OrderUserId");

                    b.ToTable("Commande", (string)null);
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.OrderProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<float>("AmountHTVA")
                        .HasColumnType("real");

                    b.Property<float>("AmountTVAC")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("Commande_Produit_NN", (string)null);
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<float>("TVA")
                        .HasColumnType("real");

                    b.HasKey("Id")
                        .HasName("PK_Product");

                    b.ToTable("Produit", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "High performance laptop",
                            Name = "Laptop",
                            Price = 1200f,
                            Stock = 10,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 2,
                            Description = "Latest model smartphone",
                            Name = "Smartphone",
                            Price = 800f,
                            Stock = 20,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 3,
                            Description = "Noise cancelling headphones",
                            Name = "Wireless Headphones",
                            Price = 200f,
                            Stock = 50,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 4,
                            Description = "Automatic coffee machine",
                            Name = "Coffee Maker",
                            Price = 150f,
                            Stock = 30,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 5,
                            Description = "Fast boiling kettle",
                            Name = "Electric Kettle",
                            Price = 50f,
                            Stock = 60,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 6,
                            Description = "High-speed blender",
                            Name = "Blender",
                            Price = 100f,
                            Stock = 40,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 7,
                            Description = "Cordless vacuum cleaner",
                            Name = "Vacuum Cleaner",
                            Price = 250f,
                            Stock = 25,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 8,
                            Description = "Latest generation console",
                            Name = "Gaming Console",
                            Price = 500f,
                            Stock = 15,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 9,
                            Description = "Waterproof fitness smartwatch",
                            Name = "Smartwatch",
                            Price = 150f,
                            Stock = 35,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 10,
                            Description = "Ultra HD 4K smart TV",
                            Name = "4K TV",
                            Price = 900f,
                            Stock = 10,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 11,
                            Description = "Energy-efficient refrigerator",
                            Name = "Refrigerator",
                            Price = 1200f,
                            Stock = 8,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 12,
                            Description = "Front load washing machine",
                            Name = "Washing Machine",
                            Price = 800f,
                            Stock = 12,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 13,
                            Description = "Automatic dishwasher",
                            Name = "Dishwasher",
                            Price = 700f,
                            Stock = 10,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 14,
                            Description = "Compact microwave oven",
                            Name = "Microwave Oven",
                            Price = 200f,
                            Stock = 40,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 15,
                            Description = "Digital camera with 4K video",
                            Name = "Camera",
                            Price = 1100f,
                            Stock = 15,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 16,
                            Description = "Bluetooth wireless speakers",
                            Name = "Speakers",
                            Price = 300f,
                            Stock = 25,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 17,
                            Description = "WiFi 6 router",
                            Name = "Router",
                            Price = 150f,
                            Stock = 50,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 18,
                            Description = "High-resolution tablet",
                            Name = "Tablet",
                            Price = 600f,
                            Stock = 20,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 19,
                            Description = "All-in-one wireless printer",
                            Name = "Printer",
                            Price = 200f,
                            Stock = 30,
                            TVA = 21f
                        },
                        new
                        {
                            Id = 20,
                            Description = "Portable air conditioner",
                            Name = "Air Conditioner",
                            Price = 700f,
                            Stock = 10,
                            TVA = 21f
                        });
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id")
                        .HasName("PK_User");

                    b.ToTable("Utilisateur", (string)null);
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Category", b =>
                {
                    b.HasOne("Projet_Boutique.DAL.Entities.Product", null)
                        .WithMany("ListeCat")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.CategoryProduct", b =>
                {
                    b.HasOne("Projet_Boutique.DAL.Entities.Category", "Category")
                        .WithMany("ProductsList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Boutique.DAL.Entities.Product", "Product")
                        .WithMany("CategoriesList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.FormatProduct", b =>
                {
                    b.HasOne("Projet_Boutique.DAL.Entities.Format", "Format")
                        .WithMany("ProductsList")
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Boutique.DAL.Entities.Product", "Product")
                        .WithMany("FormatsList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Format");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Order", b =>
                {
                    b.HasOne("Projet_Boutique.DAL.Entities.User", "OrderUser")
                        .WithMany("OrderList")
                        .HasForeignKey("OrderUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderUser");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.OrderProduct", b =>
                {
                    b.HasOne("Projet_Boutique.DAL.Entities.Order", "Order")
                        .WithMany("ProductList")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projet_Boutique.DAL.Entities.Product", "Product")
                        .WithMany("OrderList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Category", b =>
                {
                    b.Navigation("ProductsList");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Format", b =>
                {
                    b.Navigation("ProductsList");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Order", b =>
                {
                    b.Navigation("ProductList");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.Product", b =>
                {
                    b.Navigation("CategoriesList");

                    b.Navigation("FormatsList");

                    b.Navigation("ListeCat");

                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("Projet_Boutique.DAL.Entities.User", b =>
                {
                    b.Navigation("OrderList");
                });
#pragma warning restore 612, 618
        }
    }
}
