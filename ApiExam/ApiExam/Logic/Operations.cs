using ApiExam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiExam.Logic
{
    public class Operations:IOperations
    {
        /// <summary>
        /// For each multiple of 3, print "Fizz" instead of the number.
        /// For each multiple of 5, print "Buzz" instead of the number.
        /// For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public Task<List<string>> FizzBuzz(int n) {

            List<string> listFizzBuzz = new List<string>();


            for (int i = 1; i <= n; i++)
            {
                string result = null;
                if (i % 3 == 0)
                    result = "Fizz";
                if (i % 5 == 0)
                    result += "Buzz";

                listFizzBuzz.Add(result!=null ? result:i.ToString());
                
            }

            return Task.FromResult(listFizzBuzz);

        }

    }
}
