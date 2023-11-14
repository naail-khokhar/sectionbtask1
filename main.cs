/******************************************************************************
                                Fizz Buzz
                                14/11/23
*******************************************************************************/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("How far to count?");
        int HowFar;

        while (!int.TryParse(Console.ReadLine(), out HowFar) || HowFar < 1)
        {
            Console.WriteLine("Not a valid number, please try again.");
        }

        for (int MyLoop = 1; MyLoop <= HowFar; MyLoop++)
        {
            if (MyLoop % 3 == 0 && MyLoop % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (MyLoop % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (MyLoop % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(MyLoop);
            }
        }
    }
}
