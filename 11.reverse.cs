using System;
class reverse
{
    public static void Main(string[] args)
    {
        int a, last, reverse = 0;
        Console.Write("Enter Number : ");
        a = Convert.ToInt32(Console.ReadLine());
        while (a > 0)
        {
            last = a % 10;
            reverse = (reverse * 10) + last;
            a = a / 10;
        }
        Console.WriteLine("The reversed number is "+reverse);


    }
}