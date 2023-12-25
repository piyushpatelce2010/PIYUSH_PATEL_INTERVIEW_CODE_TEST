using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperSample.Algorithms
{

    public static class Algorithms
    {
       
        /*-----------------FIND FACTORIAL ALGORITHAM START------------------------*/

        /*Step 1 : START
         Step  2 :  Read the Input Number N for finding factorial
          Step 3 : Create a range of numbers from 1 to N [using the Enumerable.Range method.]
          step 4 : Use the Aggregate method to multiply all the numbers in the range together
          Step 5 : return or display resulting in the factorial value.
          Step 6 : END  */

        /*-----------------FIND FACTORIAL ALGORITHAM END------------------------*/

        //Coding Find Factorial
        public static int GetFactorial(int number)
        {
            try
            {
                int intfactorial = Enumerable.Range(1, number).Aggregate((x, y) => x * y);
                Console.WriteLine("Factorial of {0} is: {1}", number, intfactorial);
                return intfactorial;
            }
            catch
            {
                throw;
            }

        }

        /*-----------------Format SEPARATORS ALGORITHAM START------------------------*/
        /*Step 1 : START
         Step  2 :  Read the Input Number String for formatting
          Step 3 : Joint the separte list of string with comma(,).
          step 4 : find the last comma index of the string
          Step 5 : remove last Index of comma and replace with ' and'.
          Step 6 : END  */

        /*-----------------Format SEPARATORS  ALGORITHAM END------------------------*/

        //Code FormattedString
        public static string FormatSeparators(string[] lstitems)
        {
            var Itemsformatted = string.Join(",", lstitems);
            try
            {
                int intIndexlastcomma = Itemsformatted.LastIndexOf(",");

                //check comma exists or not
                //if comma exists then remove last comma from the string and replace with ' and'.
                if (intIndexlastcomma != -1)
                {
                    Itemsformatted = Itemsformatted.Remove(intIndexlastcomma, 1).Insert(intIndexlastcomma, " and ");
                }
            }
            catch
            {
                throw;
            }

            return Itemsformatted;
        }
}

   
}
