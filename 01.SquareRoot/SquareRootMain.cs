using System;

namespace _01.SquareRoot
{
    class SquareRootMain
    {
        public static void Main()
        {
            Console.WriteLine("Input an integer number:");
            string input = Console.ReadLine();

            try
            {
                int num = int.Parse(input);

                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "num", 
                        "Input integer should be non-negative!");
                }

                Console.WriteLine("sqrt({0}) = {1}", num, Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

            Console.ReadKey();
        }
    }
}
