using System;
using System.IO;
namespace Task1
{
    class MainClass
    {
   

        public static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"/Users/ayana/Documents/PP2/Week2/Task1/File1.txt", FileMode.Open, FileAccess.Read); //path, open the file and give access to read it
            StreamReader sr = new StreamReader(fs); //class to be able to read from the file

            string str = sr.ReadLine();

            sr.Close();
            fs.Close();

            isPAl(str);

        }


      

        public static void isPAl(string str)
        {
            char[] array = str.ToCharArray(); //split the string into array of chars
            int length = str.Length - 1;
            Boolean ok = false;
            for (int i = 0; i <= length; ++i) //checking string to be palindrome or not
            {
                if (array[i] == array[length])
                {
                    ok = true; //
                    length--;
                }
                else { ok = false; }

            }
            if (ok == true)
            {
                Console.WriteLine("YES");
            }
            else { Console.WriteLine("NO"); }

        }
    }
}
