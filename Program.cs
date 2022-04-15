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
            int boot = 100;
            Random random = new Random(1);
            double[] Array = Class1.myArray(boot);
            for (int i=0; i<boot; i++)
            {
                Array[i] = random.Next(7,boot);
                //Console.WriteLine(Array[i]);
               

            }
            Console.WriteLine("Сортировка");
            double x=0;
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
               // Console.WriteLine(Array[i]);
            }
            double []Array1=new double [boot];
            double y;
            int z = 0;
            int f = 0;
            for (int i = 0; i < boot; i++)
            {
                Array1[i] = (Array[i] * Array[i] - 1) / 24;
                y = Array1[i] - (int)Array1[i];
                if (y<=0)
                {
                    
                    Console.WriteLine(Array[i]);
                    z++;
                    

                }
                else
                {
                    f++;
                    

                }



            }
            Console.WriteLine("простых чисел  {0}", z);
            Console.WriteLine("составных чисел  {0}", f);

        }
    }
}
