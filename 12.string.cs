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
        string a;
        Console.Write("Enter Word : ");
        a = Console.ReadLine();
        char[] arr = a.ToCharArray();
        int left = 0;
        int right = arr.Length - 1;
        while (left < right)
        {
            char temp = arr[right];
            arr[right] = arr[left];
            arr[left] = temp;
            left++;
            right--;
        }
        string reversed = new string(arr);
        Console.Write("The Reversd word is : " + reversed);
    }
}