using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Generate(int inputvalue)
        {
            
            int value = inputvalue;
            if (value % 3 == 0)
            {
                if (value % 5 == 0)
                {
                    return "FizzBuzz";
                }
             return "Fizz";
            }
            else if (value % 5 == 0)
            {
                return "Buzz";
            }
            return value.ToString();

         }

    }
}
