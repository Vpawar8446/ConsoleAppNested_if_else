using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNested_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
           
          int firstno = 4, secondno = -2, thirdno = 10;
            if(firstno>secondno)
            {
                if (firstno > thirdno)
                {
                    Console.WriteLine("{0} is the largest ", firstno);
                }
                else
                {
                    Console.WriteLine("{0} is the largest ", thirdno);
                }
            }
            else
            {
                if(secondno>thirdno)
                {
                    Console.WriteLine("{0} is the largest ", secondno);
                }
                else
                {
                    Console.WriteLine("{0} is the largest ", thirdno);
                }
            }

        }
    }
}
