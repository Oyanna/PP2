using System;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine()); //the input str convert into int
            string str = Console.ReadLine(); 
            string[] nums = str.Split(); //splitting the input str into parts by " "
            int[] arr = new int[x]; 

            for (int i = 0; i < x; ++i)
            {
                arr[i] = int.Parse(nums[i]); //every ith element of str array convert into int and 
            }

            for (int i = 0; i < x; ++i)
            {
                Console.Write(arr[i] + " ");
                Console.Write(arr[i] + " ");
            }


        }
    }
}


/*0 -> 0 1
1 -> 2 3
2 -> 4 5*/
