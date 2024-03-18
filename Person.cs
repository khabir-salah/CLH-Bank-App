using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClhBankApp
{
    public abstract class Person
    {
        public string Lastname { get; set; }  
        public string Firstname { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public string email {get; set;}
        public string password {get; set;}
    }
}
