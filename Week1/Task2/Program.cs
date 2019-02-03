using System;

namespace Task2
{
    class Student
    {
        private string name;
        public string id;
        private int year;


        public Student(string name, int year)//Constructor
        {
            this.name = name;
            this.year = year;

        }

        public void Grow()//increment
        {
            this.year++;
        }



        public void PrintInfo() //Printing method
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.id);
            Console.WriteLine(this.year);
        }












    } 




    class MainClass
    {
        public static void Main(string[] args)
        {
            Student a = new Student("Ali", 1); 
            a.id = "12bd74638";
            a.Grow();
            a.PrintInfo();





            











        }
    }
}
