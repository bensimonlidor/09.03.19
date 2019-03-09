using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace traingel
{
	class Program
	{
 public static void Main(string[] args)
        {
            for (int i = 1; i <= 3 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
         
            for (int i = 4; i >= 1; i--)
        {
        for (int a = 1; a <= i; a++)

        {
                Console.Write(a);
        }
                 Console.WriteLine();
         }
            
        }
       
        }
}













