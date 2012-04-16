using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RefactoringPractices.MovieClasses;

namespace RefactoringPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie t12 = new Movie("Titanic 2012", "1");
            Movie HF2 = new Movie("Housefull 2 2010", "0");
            Movie chump= new Movie("Chimpanjee", "2");
            Movie shuarya = new Movie("Shaurya", "0");
            Rental titanicR = new Rental(t12, 2);
            Rental hf2R = new Rental(HF2, 3);
            Rental chimpanzeeR = new Rental(chump, 2);
            Customer anshul = new Customer("Anshul Pandey");
            anshul.AddRental(titanicR);
            anshul.AddRental(hf2R);
            anshul.AddRental(chimpanzeeR);
            anshul.PringStatement();
            Console.ReadLine();
        }
    }
}
