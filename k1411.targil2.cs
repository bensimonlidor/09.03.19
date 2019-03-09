using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lidor
{
    class Program
    {
        static void Main(string[] args)
        {
         int studentnum = Convert.ToInt32(Console.ReadLine());
            
                int class100 = studentnum / 100;
                studentnum = studentnum % 100;
                
                int class30 = studentnum / 30;
                studentnum = studentnum % 30;
                
                int class10 = studentnum / 10;
                studentnum = studentnum % 10;
        
               int noclass= studentnum/1;
               studentnum = studentnum % 1;

                Console.WriteLine(class100);
                Console.WriteLine(class30);
                Console.WriteLine(class10);
                 Console.WriteLine(noclass);
         }
       }
     }




