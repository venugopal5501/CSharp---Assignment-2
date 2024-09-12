using System;

class Pattern
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        // Upper half of the diamond
        for (int i = 1; i <= a; i++)
        {
            // Print leading spaces
            for (int j = i; j < a; j++)
            {
                Console.Write(" ");
            }
            // Print asterisks for odd rows
            if (i % 2 != 0)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }

        // Lower half of the diamond
        for (int i = a - 1; i >= 1; i--)
        {
            // Print leading spaces
            for (int j = a; j > i; j--)
            {
                Console.Write(" ");
            }
            // Print asterisks for odd rows
            if (i % 2 != 0)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
}