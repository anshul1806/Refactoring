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
        public List<Rental> rentals = new List<Rental>();
        
    }
}
