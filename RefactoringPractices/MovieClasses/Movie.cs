using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringPractices.MovieClasses
{
     public class Movie
    {
         public String _title;
         private String _priceCode;
         public String GetPriceCode ()
         {
             return this._priceCode;
         }
         public void SetPriceCode (String priceCode)
         {
             _priceCode = priceCode;
         }
         public String GetTitle()
         {
             return _title;
         }

         public Movie(String title , String priceCode)
         {
             _priceCode = priceCode;
             _title = title;
         }
         public static  String CHILDREN = "2";
         public static String REGULAR = "0";
         public static String NEW_RELEASE = "1";



    }

    

}
