using System;
namespace RefactoringDemo
{
	public class ConsoleIO
	{
		public void Display(string message)
        {
			Console.WriteLine(message);
        }

        public decimal GetDecimal(string prompt)
        {
            decimal result = -1;
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                if (!decimal.TryParse(Console.ReadLine(), out result))
                {
                    Error("Please input a proper decimal value\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            return result;
        }

        public string GetString(string prompt)
        {
            string result = "";
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                result = Console.ReadLine().Trim();
                if (result.Length == 0)
                {
                    Error("Input is required\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            return result;
        }

        public int GetInt(string prompt)
        {
            int result = -1;
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                if (!int.TryParse(Console.ReadLine(), out result))
                {
                    Error("Please input a proper integer\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            return result;
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Display(message);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}

