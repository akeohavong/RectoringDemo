using System;

namespace RefactoringDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            ConsoleIO c = new ConsoleIO();
            Controller control = new Controller();

            control.Run();
        }
    }
}