using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosfrati// my secםnd try
{
    class Program
    {
        static void Main(string[] args)
 {
    int a=33;
            int ASAROT=a/10;
            int AHADOT=a%10;
           if ( a<10 || a>99)
           {
            Console.WriteLine("the num is not do sifrati");
           }
           else if (ASAROT>AHADOT)
                {
               Console.WriteLine(a);
            Console.WriteLine(AHADOT);
            Console.WriteLine(ASAROT);
            Console.WriteLine("ASAROT");

           }
             else if (ASAROT<AHADOT)
            {
            Console.WriteLine(a);
            Console.WriteLine(AHADOT);
            Console.WriteLine(ASAROT);
            Console.WriteLine("AHADOT");
              
            }
             else if (ASAROT==AHADOT)
            {
            Console.WriteLine(a);
            Console.WriteLine(AHADOT);
            Console.WriteLine(ASAROT);
            Console.WriteLine("equal");
              
            }
            
        }
    }
}         
                     
            
            
            
            
            
            
            
            
            
       
            
           // my first try: :) 
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
            //
         
        }
      }
   }



