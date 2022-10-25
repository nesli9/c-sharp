using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //field (alan) tanımlamak
        //public string FirstName;
        public int Id { get; set; } 
        
        //properties tanımlamak. (class özelliklerini tanımlayacaksak bu kalıp kullanılmalı)
        private string _firstName; //field tanımlanır
        public string FirstName 
        {
            
            get 
            { 
                return "Mrs." + _firstName;
            }
            set 
            { 
                _firstName = value;
            } 
        }
        public string LastName { get; set; }
        public string city { get; set; }

    }
}
