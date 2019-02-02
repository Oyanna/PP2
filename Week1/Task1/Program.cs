using System;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string line1 = Console.ReadLine();//считываем инпут в виде строки
            string line2 = Console.ReadLine();//

            int n = int.Parse(line1);//инпут в виде строки конвертируем в тип инт

            string[] arr = line2.Split(); //делим строку на части между символами. полученные части закидываем в массив строк

            for (int i = 0; i < arr.Length; ++i)//пробегаемся по массиву строк
            {
                int k = 0; //переменная для счетчика составных чисел
                int x = int.Parse(arr[i]); //каждый итый элемент массива строк конвертируем в тип инт
                if (x == 1) k++; //1 не явл-ся простым

                for (int j = 2; j <= Math.Sqrt(x); ++j)//кв корень из числа х 
                {
                    if (x % j == 0) //условие при котором счисло х - составное
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
