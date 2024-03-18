// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

int[] numbers = { 10, 20, 30, 40, 50 };
double average = AverageCalculator.CalculateAverage(numbers);
Console.WriteLine("Average: " + average);
double maxvalue = AverageCalculator.Maxvalue(numbers);
Console.WriteLine("Max value: " + maxvalue);

public class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0; 

        int sum = 0;
        foreach (int num in numbers)
            sum += num;
        return (double)sum / numbers.Length;
    }

    public static double Maxvalue(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return int.MinValue;
        }

        int max = numbers[0]; 
        foreach (int num in numbers)
        {
            if (num > max)
                max = num; 
        }

        return max;
    }
}




