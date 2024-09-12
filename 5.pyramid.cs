using System;
class pyramid
{
    public static void Main(string[] args)
    {
        int count = 1;
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= a; i++)
        {

            for (int j = i; j < a; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }
    }
}