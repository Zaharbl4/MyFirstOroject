using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstOroject
{
    internal class Program
    {
        static void Main()
        {
            int boot = 10;
            Random random = new Random(5);
            int[] Array=new int[boot];
            for (int i=0; i<boot; i++)
            {
                Array[i]=random.Next(boot);
                Console.WriteLine(Array[i]);
               

            }
            Console.WriteLine("Сортировка");
            int x=0;
            for (int i = 0; i < boot; i++)
            {
                for (int j = i+1; j < boot; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        x = Array[i];
                        Array[i] = Array[j];
                        Array[j] = x;
                      
                    }
                    


                }
                Console.WriteLine(Array[i]);
            }
           
        }
    }
}
