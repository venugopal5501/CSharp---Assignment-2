using System;
class table
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number 1 : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 2 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(i + "*" + j + " " + "=" + " " + i * j);
            }

        }
    }
}