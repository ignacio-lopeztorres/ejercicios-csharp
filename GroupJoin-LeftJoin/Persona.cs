using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupJoin_LeftJoin
{
    public class Persona
    {
        public Persona() { }
        public Persona(int id) { }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int EmpresaId { get; set; }
        
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string PostalCodeCode { get; set; }
        public string CountryCodeCode { get; set;}
        public string PhoneNumberCode { get; set; }
        
    }
}
