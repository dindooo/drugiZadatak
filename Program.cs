using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drugiZadatak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=1900; i<=2100; i++)
            {
                if(((i%400==0) || (i%4==0) && (i%100!=0)))
                {
                    Console.WriteLine(i+" je prijestupna");                  
                }
                else
                {
                    Console.WriteLine(i+" nije prijestupna");                   
                }
            }
            Console.ReadKey();
        }
    }
}
