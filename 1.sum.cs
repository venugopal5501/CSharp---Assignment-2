using System;
class sum
{
    public static void Main(string[] args)
    {
        int a;
        int add = 0, average;
        Console.WriteLine("Enter Numbers: ");
        int sample = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= sample; i++)
        {
            a = Convert.ToInt32(Console.ReadLine());
            add = add + a;
        }
        average = add / sample;
        Console.WriteLine("The sum is : " + add);
        Console.WriteLine("The Average is : " + average);
    }
}