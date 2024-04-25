using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Inah World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop to input numbers
        while (true)
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 0){
                break;
            }

            numbers.Add(input);
        }

        // Calculate sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Find maximum number
        int max = numbers.Count > 0 ? numbers[0] : 0;
        foreach (int num in numbers)
        {
            if (num > max){
                max = num;
            }
        }

        // Output results
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + average);
        Console.WriteLine("The largest number is: " + max);
    }
}