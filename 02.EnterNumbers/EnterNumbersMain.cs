using System;

namespace _02.EnterNumbers
{
    class EnterNumbersMain
    {
        public static void Main()
        {
            int[] numArray = new int[10];

            while (true)
            {
                try
                {
                    // Read first number manually
                    numArray[0] = ReadNumber(1, 100);
                    break;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            for (int i = 1; i < numArray.Length; i++)
            {
                try
                {
                    numArray[i] = ReadNumber(numArray[i - 1], 100);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number!");
                    i--;
                }
            }

            PrintArray(numArray);

            Console.ReadKey();
        }

        public static int ReadNumber(int start, int end)
        {
            Console.Write("Input an integer number: ");
            int num = 0;

            try
            {
                num = int.Parse(Console.ReadLine());

                if (num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                throw;
            }
            catch (ArgumentOutOfRangeException)
            {
                string msg = string.Format("Input number should be in range [{0}-{1}]", start, end);

                throw new ArgumentOutOfRangeException(msg);
            }

            return num;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length - 2; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine(array[array.Length - 1]);
        }
    }
}
