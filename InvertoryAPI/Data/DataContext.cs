using Microsoft.EntityFrameworkCore;
using System;
using InvertoryAPI;

namespace InvertoryAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

                 public DbSet<Product> Product { get; set; }
                 public DbSet<Sales> Sales { get; set; }
                 public DbSet<Customer> Customer { get; set; }
                 public DbSet<Coupons> Coupons { get; set; }
                 public DbSet<Purchases> Purchases { get; set; }
                 public DbSet<Suppliers> Suppliers { get; set; }
                 public DbSet<InvertoryAPI.Roleaccess>? Roleaccess { get; set; }
                 public DbSet<InvertoryAPI.Employees>? Employees { get; set; }


    }
    }
