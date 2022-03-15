using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 5;
            ar[1] = 59;
            ar[2] = 4;
            ar[3] = 90;
            ar[4] = 39;
           // Console.WriteLine(ar[4]);
           for(int i = 0; i <ar.Length; i++)
            {
                Console.WriteLine(ar[i]);
           }
            Console.WriteLine("#################");
            // foreach(int i in ar)
            //{
            //  Console.WriteLine(i);
            //}
            int[] b = new int[5];
            //without loop

            //b[0] = ar[0];
            //b[1] = ar[1];
            //b[2] = ar[2];
            //b[3] = ar[3];
            //b[4] = ar[4];
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = ar[i];
                Console.WriteLine(b[i]);

            }
                        Console.WriteLine("#################");

            //for (int j = 0; j < b.Length; j++)
            //{


            //    Console.WriteLine(b[j]);

            //}
            int sum = 0;
            for(int k = 0; k < ar.Length; k++)
            {
                sum = sum + ar[k];

            }
            Console.WriteLine(sum);
            Console.WriteLine("#################");


            Array.Sort(ar);
            foreach(int l in ar)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("#################");


            //for (int i = 0; i < ar.Length; i++)
            //{


            //    Console.WriteLine(ar[i]);
            //}
            Console.WriteLine("#################");

            int max = ar[ar.Length-1];
            Console.WriteLine(max);
            Console.WriteLine("#################");

            int min = ar[0];
            Console.WriteLine(min);
            Console.WriteLine("#################");

            Array.Reverse(ar);
            for(int l = 0; l < ar.Length; l++)
            {
                Console.Write(ar[l]+" ");
               // Console.Write(" ");
            }

        }
    }
}
