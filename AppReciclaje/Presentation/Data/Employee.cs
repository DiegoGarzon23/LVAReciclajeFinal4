using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LVAReciclajeTPDA.Data
{
    public class Employee: IEntity
    {
      
        public int Id { get; set; }
        
        public string FullName { get; set; }
        
        public int NumberPhone { get; set; }
       
        public string ContactEmail { get; set; }
       
        public string Address { get; set; }
        
        public int ZipCode { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
       
        public string Gender { get; set; }
      
        public string MaritalStatus { get; set; }
        
        public string PlaceOfBirth { get; set; }
        
        public string HealthInsurance { get; set; }
       
        public string ImageUrl { get; set; }


        public ICollection<Sale> Sales { get; set; }
      
    }
}
