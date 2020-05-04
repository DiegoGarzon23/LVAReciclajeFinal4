using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Provider
    {
       
        public int Id { get; set; }
        
        public string EnterpriseName { get; set; }
       
        public string Brand { get; set; }
        
        public string Address { get; set; }
        
        public string City { get; set; }
        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
      
        public string Mail { get; set; }
       
        public string Web { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }

    }
}
