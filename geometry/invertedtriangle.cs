using System;
public static class invertedtriangle
{
    public static void Main(string[] args)
    {
       
        
    }
    public void printTriangle(int n)
    {
         Console.WriteLine("Please input n :"); 
         int n = Convert.ToInt32(Console.ReadLine());
         for (int i = n; i > 0; i--)
         {
            for (int j=0; j < int; j++)
            {
                Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
         }
    }
}