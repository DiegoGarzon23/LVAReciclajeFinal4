using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Client
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public string Surnames { get; set; }
       
        public string Rfc { get; set; }
       
        public string Curp { get; set; }
        
        public int Phone { get; set; }
       
        public string Address { get; set; }
        
        public int PostalCode { get; set; }
       
        public string Contact { get; set; }
        

        public string ImageUrl { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
