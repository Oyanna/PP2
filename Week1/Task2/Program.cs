using System;

namespace Task2
{
    class Student
    {
        private string name;
        public string id;
        public int year;


        public Student(string str, int x)
        {
            name = str;
            year = x;

        }

        public void Grow (int y)
        {
            y = y + 1;
        }









    } 




    class MainClass
    {
        public static void Main(string[] args)
        {
            Student a = new Student("Ali", 1);
            a.id = "1765255";
            a.Grow(a.year);

            Console.WriteLine(a.year);
            











        }
    }
}
