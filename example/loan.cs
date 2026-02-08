using System; 
using System.Collections.Generic;
public class loan
{
    double money = 1.0; 
    int month = 1; 
    double interestRate = 1.0; 
    public loan(double money, int month, double interestRate)
    {
        Console.WriteLine("Enter money: ");
        money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter month:"); 
        month = Convert.ToInt32(Console.ReadLine());
        if (0< month && month > 12 )
        {
            Console.WriteLine("error: month dont have that value irgonre 1 => 12 , please enter again"); 
            month = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Please enter interest rate:"); 
        interestRate = Convert.ToDouble(Console.ReadLine());
        
        double totalInterset = 0; 
        for (int i = 0; i < month; i++)
        {
            totalInterset += money * (interestRate / 100) / 12;
        }
        Console.WriteLine("Total interest: {0}", totalInterset);
    }
}
