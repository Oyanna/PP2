using System;
using System.Collections.Generic;
using System.IO;
namespace FarManager
{


    class Layer
    {


        public FileSystemInfo[] Content
        {
            get;
            set;
          
        }



        int selectedItem;

        public int SelectedItem
        {
            get { return selectedItem; }

            set
            {

                if (value < 0)
                {
                    selectedItem = Content.Length - 1;
                }

                else if (value >= Content.Length)
                {
                    selectedItem = 0;
                }

                else
                {
                    selectedItem = value;
                }


            }

        }



        public void Print()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.BackgroundColor = ConsoleColor.DarkRed;

            Console.Clear();

            for (int i = 0; i < Content.Length; ++i)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                }

                Console.WriteLine(i + 1 + ". " + Content[i].Name);

            }

        }
    }

       















    class MainClass
    {
        public static void Main(string[] args)
        {
            DirectoryInfo origin = new DirectoryInfo(@"/Users/ayana/Documents/for testing");
            FileSystemInfo[] fsi = origin.GetFileSystemInfos();









            Stack<Layer> history = new Stack<Layer>();
            // ObjectType objectType = ObjectType.DirectoryView;
            history.Push(
            new Layer
            {
                Content = fsi,
                SelectedItem = 0});

            history.Peek().Print();



            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--;
                        history.Peek().Print();
                        break;

                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;
                        history.Peek().Print();
                        break;



                    case ConsoleKey.Enter:
                        int picked = history.Peek().SelectedItem;
                        FileSystemInfo fas = history.Peek().Content[picked];
                        if (fas is DirectoryInfo)
                        {
                            history.Push(new Layer { Content = ((DirectoryInfo)fas).GetFileSystemInfos(), SelectedItem = 0 });
                            history.Peek().Print();
                        }
                        else if (fas is FileInfo)
                        {
                            using (FileStream fs = new FileStream(fas.FullName, FileMode.Open, FileAccess.Read))
                            {
                                using (StreamReader sr = new StreamReader(fs))
                                {
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.Clear();
                                    Console.WriteLine(sr.ReadToEnd());
                                }
                            }
                        }

                        break;


                    
                    case ConsoleKey.Backspace:
                        history.Pop();
                        history.Peek().Print();
                     break;


                    
                    
                    case ConsoleKey.Escape:
                        int x = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[x];
                       
                         if (fileSystemInfo is DirectoryInfo)
                        {
                            DirectoryInfo cop = fileSystemInfo as DirectoryInfo;
                            Directory.Delete(fileSystemInfo.FullName, true);
                            history.Peek().Content = cop.Parent.GetFileSystemInfos();
                            history.Peek().Print();
                        }
                         else if (fileSystemInfo is FileInfo)
                        {
                            FileInfo file = fileSystemInfo as FileInfo;
                            File.Delete(fileSystemInfo.FullName);
                            history.Peek().Content = file.Directory.GetFileSystemInfos();
                        }
                        history.Peek().SelectedItem--;
                        break;

                    case ConsoleKey.Tab:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Clear();
                        string NewName = Console.ReadLine();
                        int x3 = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo2 = history.Peek().Content[x3];

                        if (fileSystemInfo2 is DirectoryInfo)
                        {
                            DirectoryInfo poc = fileSystemInfo2 as DirectoryInfo;
                            Directory.Move(fileSystemInfo2.FullName, poc.FullName + "/" + NewName);
                            history.Peek().Content = poc.Parent.GetFileSystemInfos();

                        }
                        else
                        {
                            FileInfo f = fileSystemInfo2 as FileInfo;
                            File.Move(fileSystemInfo2.FullName, f.FullName + "/" + NewName);
                            history.Peek().Content = f.Directory.GetFileSystemInfos();
                        }
                        break;

                }
            }

















        }
    }
}
