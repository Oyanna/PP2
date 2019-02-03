using System;




namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//converting input into int
            string[,] arr = new string[n, n];//2d array
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i >= j)
                    {
                        arr[i, j] = "[*]";
                    }
                }
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

   



    /*0    1    2    3        n = 4

0  !

1  !    !   

2  !    !    !

3  !    !    !    !*/
