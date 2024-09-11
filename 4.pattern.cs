using System;

class pattern{
    public static void Main(string []args){
        int a;
        Console.Write("Enter Number : ");
        a=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=a;i++){
            for(int j=1;j<=i;j++){
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}