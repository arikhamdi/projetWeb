using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetWeb.Models
{
    public class Establishment
    {
        public long ID { get; set; }

        public string Name { get; set; }
        
        // public enum Type
        // {
        //     Bar,
        //     NightClub,
        //     ConcertHall,
        //     StudentCircle
        // }
        
        
        public string Vat { get; set; }
        
        // public string EmailPro { get; set; }
        //
        // public string Description { get; set; }
        //
        // public string Address { get; set; }
        //
        // public string PostalCode { get; set; }
        //
        // public string City { get; set; }
        //
        // public string Country { get; set; }
        //
        // public string Street { get; set; }
        //
        // public string StreetNumber { get; set; }
        //
        // public string PhoneNumber { get; set; }
        //
        // public string Email { get; set; }
        //
        // public string WebSite { get; set; }
        // public string Instagram { get; set; }
        // public string Facebook { get; set; }
        // public string Linkedin { get; set; }
        //
        // public string[] picture { get; set; }




    }
}
