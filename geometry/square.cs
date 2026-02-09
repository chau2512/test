using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("please input n :");
        int n = Convert.ToInt32(Console.ReadLine());

       
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
