using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosfrati
{
    class Program
    {
        static void Main(string[] args)
 {
           int x;
           int x = Convert.ToInt32(Console.ReadLine());
            int asarot=x/10;
            int ahadot=x%10;
           if ( x<10 || x>99) 
           {
            Console.WriteLine("not do sfrati");
            } 
            else if (asarot>ahadot)
            {
             Console.WriteLine(asarot);
             Console.WriteLine(ahadot);
            Console.WriteLine("asarot");
            }
            else
            {
            Console.WriteLine(asarot);
            Console.WriteLine(ahadot);
             Console.WriteLine("ahadot");
            }
         
        }
      }
   }



