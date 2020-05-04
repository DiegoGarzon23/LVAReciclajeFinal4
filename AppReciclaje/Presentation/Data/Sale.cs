using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Sale: IEntity
    {
        
        public int Id { get; set; }
        public string FullNameSeller { get; set; }
        public int SellerPhone { get; set; }
        public string SellerEmail { get; set; }
        public string Product { get; set; }
        public string Billing { get; set; }
        public string SendTo { get; set; }
        public string Address { get; set; }
        public int CompanyPhone { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double SalePrice { get; set; }
        
        

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<Employee> Employees { get; set; }
    

    }
}
