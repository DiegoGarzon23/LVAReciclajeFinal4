namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surnames = c.String(),
                        Rfc = c.String(),
                        Curp = c.String(),
                        Phone = c.Int(nullable: false),
                        Address = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Contact = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        NumberPhone = c.Int(nullable: false),
                        ContactEmail = c.String(),
                        Address = c.String(),
                        ZipCode = c.Int(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        PlaceOfBirth = c.String(),
                        HealthInsurance = c.String(),
                        ImageUrl = c.String(),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullNameSeller = c.String(),
                        SellerPhone = c.Int(nullable: false),
                        SellerEmail = c.String(),
                        Product = c.String(),
                        Billing = c.String(),
                        SendTo = c.String(),
                        Address = c.String(),
                        CompanyPhone = c.Int(nullable: false),
                        City = c.String(),
                        ZipCode = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Description = c.String(),
                        SalePrice = c.Double(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.PurchaseDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AssingmentDate = c.String(),
                        Description = c.String(),
                        Product_Id = c.Int(),
                        Sale_Id = c.Int(),
                        Provider_Id = c.Int(),
                        Purchase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Sales", t => t.Sale_Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Sale_Id)
                .Index(t => t.Provider_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        Code = c.Int(nullable: false),
                        TypeProduct = c.String(),
                        Purchase_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Purchases", t => t.Purchase_Id)
                .Index(t => t.Purchase_Id);
            
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        AssingmentDate = c.String(),
                        Description = c.String(),
                        Product_Id = c.Int(),
                        Sale_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Sales", t => t.Sale_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Sale_Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EnterpriseName = c.String(),
                        Brand = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Mail = c.String(),
                        Web = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullNameBuyer = c.String(),
                        NumberPhone = c.Int(nullable: false),
                        ContactEmail = c.String(),
                        PurchaseProduct = c.String(),
                        Billing = c.String(),
                        Company = c.String(),
                        Address = c.String(),
                        CompanyPhone = c.Int(nullable: false),
                        City = c.String(),
                        Quantity = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        Provider_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Providers", t => t.Provider_Id)
                .Index(t => t.Provider_Id);
            
            CreateTable(
                "dbo.SaleEmployees",
                c => new
                    {
                        Sale_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sale_Id, t.Employee_Id })
                .ForeignKey("dbo.Sales", t => t.Sale_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Sale_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.PurchaseDetails", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.Products", "Purchase_Id", "dbo.Purchases");
            DropForeignKey("dbo.PurchaseDetails", "Provider_Id", "dbo.Providers");
            DropForeignKey("dbo.Sales", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Employees", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.PurchaseDetails", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.PurchaseDetails", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.SaleEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.SaleEmployees", "Sale_Id", "dbo.Sales");
            DropIndex("dbo.SaleEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.SaleEmployees", new[] { "Sale_Id" });
            DropIndex("dbo.Purchases", new[] { "Provider_Id" });
            DropIndex("dbo.SaleDetails", new[] { "Sale_Id" });
            DropIndex("dbo.SaleDetails", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "Purchase_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Purchase_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Provider_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Sale_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Product_Id" });
            DropIndex("dbo.Sales", new[] { "Client_Id" });
            DropIndex("dbo.Employees", new[] { "Client_Id" });
            DropTable("dbo.SaleEmployees");
            DropTable("dbo.Purchases");
            DropTable("dbo.Providers");
            DropTable("dbo.SaleDetails");
            DropTable("dbo.Products");
            DropTable("dbo.PurchaseDetails");
            DropTable("dbo.Sales");
            DropTable("dbo.Employees");
            DropTable("dbo.Clients");
        }
    }
}
