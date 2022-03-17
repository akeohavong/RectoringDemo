using System;
namespace RefactoringDemo
{
    public class Controller
    {
        ConsoleIO io = new ConsoleIO();
   
        public void Run()
        {
            io.Display("==============");
            io.Display("Tip Calculator");
            io.Display("==============");
            io.Display("");

            decimal bill = io.GetDecimal("How much was your bill without tax? ");
            io.Display("How good was the service?");
            io.Display("1 - Incredible");
            io.Display("2 - Good");
            io.Display("3 - OK");
            io.Display("4 - Bad");
            io.Display("5 - Terrible");
       
            int input = io.GetInt("Enter a number 1 - 5");
            decimal tip = 0;

            //working on switch
            //switch (input)
            //{
            //    case (int)Tip.INCREDIBLE:
            //        tip = .30m;
            //        break;
            //    case (int)Tip.GOOD:
            //        tip
            //}




            if (input == (int)Tip.INCREDIBLE)
            {
                tip = .30m;
            }

            if (input == (int)Tip.GOOD)
            {
                tip = .20m;
            }

            if (input == (int)Tip.OK)
            {
                tip = .15m;
            }

            if (input == (int)Tip.BAD)
            {
                tip = .10m;
            }

            if (input == (int)Tip.TERRIBLE)
            {
                tip = .05m;
            }

            if (tip == 0)
            {
                io.Display("You didn't enter a valid selection");
            }
            else
            {
                io.Display($"Tip: {bill * tip:c}");
                io.Display($"Total: {bill + (tip*bill):c}");
            }
        }

    }
    
}
    
      

