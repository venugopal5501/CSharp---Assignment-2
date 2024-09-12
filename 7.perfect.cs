using System;

class pattern
{
    public static void Main(string[] args)
    {
        int add=0;
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1;i < a; i++){
            if(a%i==0){
                add =add+i;
            }
        }
        if(add==a){
            Console.WriteLine("Yes Perfect Number");
        }
        else{
            Console.WriteLine("Not a Perfect Number");
        }

    }
}