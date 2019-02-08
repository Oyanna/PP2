using System;
using System.IO;

namespace Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"/Users/ayana/Documents/PP2/Week2/Task2/File.2.txt", FileMode.Open, FileAccess.Read);//open file from the path and gibe access to read it
            StreamReader sr = new StreamReader(fs); //class able to read from file
            string str = sr.ReadToEnd();
            sr.Close();
            fs.Close();

            string[] arr = str.Split();//splitting the string by " "

            isPrime(arr);

        }



       public static void outputRES(string res)
        {
            FileStream fs2 = new FileStream(@"/Users/ayana/Documents/PP2/Week2/Task2/OutputFile2.txt", FileMode.OpenOrCreate, FileAccess.Write);//opportunities to read from the file or to write in file
            StreamWriter sw = new StreamWriter(fs2);
            sw.Write(res);

            sw.Close();
            fs2.Close();
        
        }






        private static void isPrime(string[] arr)
        {
            string res = ""; //will remember the needed result
            for(int i = 0; i < arr.Length; ++i)
            {
                int x = int.Parse(arr[i]);//converts every element of an array into int 
                int k = 0; //counter
                if (x == 1) k++;
                for (int j = 2; j <= Math.Sqrt(x); ++j)//prime test
                {
                    if (x % j == 0) k++;
                }
                if (k==0)//the number has no dividers except 1 and itself
                {
                    res = res + arr[i] +" ";
                }
            }


            outputRES(res);
        }



    }
}
