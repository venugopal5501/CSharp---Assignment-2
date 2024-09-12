using System;
class armstrong
{

    static bool arm(int x)
    {
        int add = 0;
        int y = x;
        string conversion = x.ToString();
        int length = conversion.Length;

        while (x > 0)
        {
            int last = x % 10;
            int power = (int)Math.Pow(last, length);
            add = add + power;
            x = x / 10;
        }
        return add == y;
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter starting range : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Ending range : ");
        int b = Convert.ToInt32(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            if (arm(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}