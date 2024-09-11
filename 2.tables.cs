using System;
class tables{
    public static void Main(string []args){
        int a;
        Console.Write("Enter Number : ");
        a=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=20;i++){
            Console.WriteLine(i +" * " +a +" = " +i*a);
        }
    }
}