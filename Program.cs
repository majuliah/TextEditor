using System;
using System.IO;
using static System.Console;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void Menu()
        {
            Clear();
            WriteLine($"Hey! What do you want to do? ");
            WriteLine($"*** [ 1 ] Open file       ***");
            WriteLine($"*** [ 2 ] Edit file       ***");
            WriteLine($"*** [ 0 ] Close           ***");

            short option = short.Parse(ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            
        }

        static void Edit()
        {
            Clear();
            WriteLine($"You are now editing texts.");
            WriteLine($"***                    ***");

            string editor ="";

            do
            {
                editor += ReadLine();
                editor += Environment.NewLine;
            } while (ReadKey().Key !=  ConsoleKey.Escape);
            
            Write(editor);
            
            
        }

        static void Save(string text)
        {
            Clear();
            WriteLine($"Text the path where you want to save the file.");
            var path = ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            
            
            
            
            
            
        }
    }
}