using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Function to calculate the mean
    static double CalculateMean(List<int> data)
    {
        double sum = data.Sum();
        return sum / data.Count;
    }

    // Function to calculate the median
    static double CalculateMedian(List<int> data)
    {
        data.Sort();
        int n = data.Count;
        if (n % 2 == 0)
        {
            return (data[n / 2 - 1] + data[n / 2]) / 2.0;
        }
        else
        {
            return data[n / 2];
        }
    }

    // Function to calculate the mode
    static int CalculateMode(List<int> data)
    {
        var frequency = new Dictionary<int, int>();
        foreach (int num in data)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        int mode = data[0];
        int maxCount = 0;
        foreach (var pair in frequency)
        {
            if (pair.Value > maxCount)
            {
                maxCount = pair.Value;
                mode = pair.Key;
            }
        }
        return mode;
    }

    static void Main()
    {
        // Sample list of numbers
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 5, 6, 7, 8, 9, 9, 9 };

        // Calculate mean
        double mean = CalculateMean(data);
        Console.WriteLine("Mean: " + mean);

        // Calculate median
        double median = CalculateMedian(data);
        Console.WriteLine("Median: " + median);

        // Calculate mode
        int mode = CalculateMode(data);
        Console.WriteLine("Mode: " + mode);
    }
}

