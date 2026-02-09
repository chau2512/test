using System;
public class triangle 
{
    public static void Main(string[] args)
    {
       printTriangle(n);
    }
    public void printTriangle(int n)
    { 
        Console.WriteLine("please input n :");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i< n; i++)
        {
            Console.WriteLine("*");
            Console.WriteLine();
            for (int j =0; j < i; j++)
            {
                Console.Write("*");
            }
        }}
}