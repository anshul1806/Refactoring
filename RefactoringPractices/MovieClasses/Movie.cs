using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringPractices.MovieClasses
{
     public class Movie
    {
         public String _title;
         private int _priceCode;
         public int GetPriceCode ()
         {
             return this._priceCode;
         }
         public void SetPriceCode (int priceCode)
         {
             _priceCode = priceCode;
         }
         public String GetTitle()
         {
             return _title;
         }

         public Movie(String title , int priceCode)
         {
             _priceCode = priceCode;
             _title = title;
         }
         public const int CHILDREN = 2;
         public const int REGULAR = 0;
         public const int NEW_RELEASE = 1;



    }

    

}
