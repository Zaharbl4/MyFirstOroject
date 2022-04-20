using System;



    public static void sort()
    {
        double[] Array;
        double x = 0;
        for (int i = 0; i < boot; i++)
        {
            for (int j = i + 1; j < boot; j++)
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
    }
	
	

