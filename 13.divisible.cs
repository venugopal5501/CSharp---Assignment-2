using System;
class division{
    public static void Main(string []args){
        int a=100,b=200,add=0;
        for(int i=a;i<=b;i++){
            if(i%9==0){
                Console.WriteLine(i);
                add=add+i;
            }
        }
        Console.Write(add);
    }
}