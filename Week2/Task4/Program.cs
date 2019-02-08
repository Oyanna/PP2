using System;
using System.IO;

namespace Task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string FolderName = @"/Users/ayana/Documents/PP2/Week2/Task4";
            string PathString = Path.Combine(FolderName, "Folder1");  //name to a path
            Directory.CreateDirectory(PathString);//creates directory
            string fileName = "File1.txt";//name of file
            PathString = Path.Combine(PathString, fileName);

            string FolderName2 = @"/Users/ayana/Documents/PP2/Week2/Task4";
            string PathString2 = Path.Combine(FolderName2, "Folder2");
            Directory.CreateDirectory(PathString2);


            if (!File.Exists(PathString))

            {


                using (FileStream fs = File.Create(PathString))
                {

                    for (byte i = 0; i < 100; ++i)
                    {
                        fs.WriteByte(i);
                    }

                }
            }


           


             
            else

            {
                Console.WriteLine("File \"{0}\" already exists.", fileName);
                return;
            }





            string path1 = @"/Users/ayana/Documents/PP2/Week2/Task4/Folder1";
            string path2 = @"/Users/ayana/Documents/PP2/Week2/Task4/Folder2";

            string bef = Path.Combine(path1, fileName);
            string af = Path.Combine(path2, fileName);
            Directory.CreateDirectory(path2);//new directory
            File.Copy(bef, af, true); //copies a file from one path to another


          
              
              
            if (File.Exists(@"/Users/ayana/Documents/PP2/Week2/Task4/Folder1/File1.txt"))
            {


                    try
                    {

                        File.Delete(@"/Users/ayana/Documents/PP2/Week2/Task4/Folder1/File1.txt");

                    }

                    
                    
                    
                    catch(IOException e)
                   {


                    Console.WriteLine(e.Message);
                    return;


                   }




            }




            }




    }



}
