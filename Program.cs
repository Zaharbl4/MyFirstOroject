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
            int boot = 10000000;//  <= запусти это говно заработало))
            Random random = new Random(1);
            double[] Array = Class1.myArray(boot);
            for (int i=0; i<boot; i++)
            {
                Array[i] = random.Next(7,boot);
                //Console.WriteLine(Array[i]);
               

            }
            Console.WriteLine("Сортировка");
           
            double []Array1 = Class1.myArray1(boot);
            double y;
            int z = 0;
            int f = 0;
            for (int i = 0; i < boot; i++)
            {
                Array1[i] = (Array[i] * Array[i] - 1) / 24;
                y = Array1[i] - (long)Array1[i];
                if (y<=0)
                {
                    
                    //Console.WriteLine(Array[i]);
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
