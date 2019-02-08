using System;

namespace ooops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            String str2 = Console.ReadLine();

            int n = int.Parse(str1); //converting string to int
            string[] arr = str2.Split();
            int[] doublearr = new int[2 * n]; //new array that has twice more elements than the given one

            for (int i = 0; i < n; ++i)
            {
                int x = int.Parse(arr[i]);//converting into int every elemenet of the given array
                doublearr[2 * i] = doublearr[2 * i + 1] = x; 

            }
            for (int i = 0; i < 2 * n; ++i)
            {
                Console.Write(doublearr[i] + " ");
            }
        }
    }
}
