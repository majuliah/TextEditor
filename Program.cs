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
            
        }
    }
}