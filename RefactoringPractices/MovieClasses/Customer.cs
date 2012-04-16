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
        public void  AddRental (Rental rental )
        {
            Rentals.Add(rental);
        }
        public String PringStatement ()
        {
            String statement = "Your total rental Charges";
            double finalAmt = 0;
            int rentalPoints = 0;
            // local vars
            double totalAmount = 0.0;
            int frqRentalPoints = 0;
            foreach (Rental rental in Rentals)
            {
               
                Movie movie = rental.getMovie();
                String moviePriceCode = movie.GetPriceCode();
                switch (moviePriceCode)
                {
                    case "2":
                        totalAmount += 1.5;
                        if (rental.getRentedDays() > 3)
                        {
                            totalAmount += (rental.getRentedDays() - 3) * 1.5;
                        }
                        break;
                    case "0":
                         totalAmount += 2;
                        if (rental.getRentedDays() > 2)
                        {
                            totalAmount += (rental.getRentedDays() - 2) * 1.5;
                        }
                        break;
                    case "1":
                        totalAmount += rental.getRentedDays()*3;
                        break;
                    default:
                        break;
                }
                frqRentalPoints++;
                finalAmt += totalAmount;
                if (rental.getMovie().GetPriceCode().Equals(Movie.NEW_RELEASE) && rental.getRentedDays() > 1)
                    frqRentalPoints++;
                rentalPoints += frqRentalPoints;
                Console.WriteLine("For Movie :: " + rental.getMovie().GetTitle() + "you were charged" + totalAmount + "& you earned " + frqRentalPoints +"points.");
                frqRentalPoints = 0;
                totalAmount = 0;
            }
            Console.WriteLine("**********************************closing Statement****************** ");
            Console.WriteLine("Total movies rented ::" + Rentals.Count +"Total charges  " + finalAmt + "Total rental points earned " + rentalPoints);
            return statement;
        }
        
    }
}
