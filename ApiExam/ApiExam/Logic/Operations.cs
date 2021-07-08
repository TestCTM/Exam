using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExam.Logic
{
    public class Operations
    {
        /// <summary>
        /// For each multiple of 3, print "Fizz" instead of the number.
        /// For each multiple of 5, print "Buzz" instead of the number.
        /// For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> FizzBuzz(int n) {

            List<string> listFizzBuzz = new List<string>();


            for (int i = 1; i <= n; i++)
            {

                if (i % 3 == 0 && i % 5 != 0)
                    listFizzBuzz.Add("Fizz");
                else if (i % 5 == 0 && i % 3 != 0)
                    listFizzBuzz.Add("Buzz");
                else if (i % 5 == 0 && i % 3 == 0)
                    listFizzBuzz.Add("FizzBuzz");
                else
                    listFizzBuzz.Add(i.ToString());
            }



            return listFizzBuzz;

        }

    }
}
