using System;
class binary
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Binary Number : ");
        int b = Convert.ToInt32(Console.ReadLine());
        // int a = b.ToString().Length;
        int add = 0;
        int i = 0;
        while (b > 0)
        {
            int last = b % 10;
            int power = (int)Math.Pow(2, i) * last;
            add = add + power;
            b = b / 10;
            i++;
        }

        Console.Write(add);
    }
}