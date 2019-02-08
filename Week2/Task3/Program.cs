using System;
using System.IO;

namespace Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DirectoryInfo Hey = new DirectoryInfo(@"/Users/ayana/VirtualBox VMs");
            A(Hey, 1);
        }

        private static void A(FileSystemInfo all, int ot)
        {
            string space = new string(' ', ot); //space to be able to see that we are in a new folder
            space = space + all.Name;  
            Console.WriteLine(space); //see on console names of folders and files we are working with


            if (all is DirectoryInfo) // is the considering object is a folder
            {

                var items = (all as DirectoryInfo).GetFileSystemInfos(); //obtain all files and folders from the consireing folder
                foreach (var i in items) //check the containing of the folder
                {
                    A(i, ot + 3);//keep going till no folders left
                }
            }
        }














    }






}
