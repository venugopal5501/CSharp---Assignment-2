using System;
class octal
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int add = 0;
        int adds = 0;
        while (a > 0)
        {
            int last = a % 8;
            add = (add * 10) + last;
            a = a / 8;
        }
        while (add > 0)
        {
            int lasts = add % 10;
            adds = adds * 10 + lasts;
            add = add / 10;
        }
        Console.Write("The octal value is : " + adds + " 8");

    }
}