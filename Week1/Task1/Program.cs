using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();

            int n = int.Parse(line1);//convert the input string into int

            string[] arr = line2.Split(); //splits the line and puts its parts into array

            for (int i = 0; i < arr.Length; ++i)//
            {
                int k = 0; //counter
                int x = int.Parse(arr[i]);//convert into int
                if (x == 1) k++; //exclude "1"

                for (int j = 2; j <= Math.Sqrt(x); ++j)//square root of x using math
                {
                    if (x % j == 0) //notprime
                        k++;
                }
                if (k == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
