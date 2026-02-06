using System;

public class BodyMassIndex
{
    public void CalculateBMI()
    {
        float Weight;
        float Height;

        Console.WriteLine("Enter input Weight please (kg):");
        Weight = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter input Height please (m):");
        Height = float.Parse(Console.ReadLine());
        float BMI = Weight / (Height * Height);
        Console.WriteLine(" your BMI : " + BMI);
        if (BMI < 18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if (BMI < 25)
        {
            Console.WriteLine("Normal weight");
        }
        else if (BMI < 30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obesity");
        }

    }
}
