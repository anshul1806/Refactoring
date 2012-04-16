using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace RefactoringPractices.MovieClasses
{
    class Customer
    {
        public String Name { get; set; }
        public List<Rental> Rentals = new List<Rental>();
        public Customer(String _name)
        {
            Name = _name;
        }
        public AddRental (Rental rental )
        {
            Rentals.Add(rental);
        }
        public String PringStatement ()
        {
        
        }
        
    }
}
