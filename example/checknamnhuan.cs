using System;
public class checknamnhuan
{
    static void Main(string[] args)
    {
        Console.WriteLine("input a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year % 4 && year % 400 == 0)
        {
            Console.WriteLine("{0} la nam nhuan", year);
        }
        else
        {
            Console.WriteLine("{0} khong phai la nam nhuan", year);
        }
    }
}