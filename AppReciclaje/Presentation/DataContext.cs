using LVAReciclajeTPDA.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;


namespace LVAReciclajeTPDA
{
    public class DataContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }

        public DataContext():base("name=con")
        {

        }


    }
}
