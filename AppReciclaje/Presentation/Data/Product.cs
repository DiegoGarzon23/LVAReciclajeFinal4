using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Product: IEntity
    {
        
        public int Id { get; set; }
       
        public string Name { get; set; }
        
        public double Quantity { get; set; }
        public double Price { get; set; }
        
        public string Description { get; set; }
        public int Code { get; set; }
       
        public string TypeProduct { get; set; }

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<SaleDetail> SaleDetails { get; set; }


    }
}
