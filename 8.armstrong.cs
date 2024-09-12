using System;
class armstrong
{
    public static void Main(string[] args)
    {

        int add = 0;
        Console.Write("Enter number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = a;
        int length = a.ToString().Length;

        while (a > 0)
        {
            int last = a % 10;
            int power = (int)Math.Pow(last, length);
            add = add + power;
            a = a / 10;
        }
        if (add == b)
        {
            Console.Write("The given number is armstrong number");
        }
        else
        {
            Console.Write("Not a armstrong number");
        }

    }

}