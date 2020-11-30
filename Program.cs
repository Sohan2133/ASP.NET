using System;

namespace bubble_sort
{
    class Program
    {
        public static void Main()
        {
            int[] a = new int[100];
            Console.WriteLine("Number of elements in the array ?");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            Console.WriteLine(" Array elements ");
            Console.WriteLine();
            for (int j = 0; j < x; j++)
            {
                string s1 = Console.ReadLine();
                a[j] = Int32.Parse(s1);
            }
            int limit = x - 1;
            for (int pass = 0; pass < x - 1; pass++)
            {
                for (int j = 0; j < limit - pass; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int k = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = k;
                    }


                }
            }
            Console.WriteLine();
            Console.WriteLine("Sorted elements of an array are(bubble sort)");
            for (int j = 0; j < x; j++)
                Console.WriteLine(a[j]);
        }
    }
}



