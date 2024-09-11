// using System;
// class word{
//     public static void Main(string []args){
//         string a;
//         Console.Write("Enter Word : ");
//         a=Console.ReadLine();
//         for(int i=a.Length-1;i>=0;i--){
//             Console.Write(a[i]);  
//         }

//     }
// }

using System;

class word
{
    public static void Main(string[] args)
    {
        int temp,left=0;
        string a;
        Console.Write("Enter Word : ");
        a = Console.ReadLine();
        int right=a.Length-1;
        while(a[left]<a[right]{
            temp=a[right];
            a[right]=a[left];
            a[left]=temp;
        })


    }
}